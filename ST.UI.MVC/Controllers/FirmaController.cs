using System;
using System.IO;
using System.Web.Helpers;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ST.BLL.Repository;
using ST.BLL.Settings;
using ST.Models.Entities;
using ST.Models.ViewModels;

namespace ST.UI.MVC.Controllers
{
    [Authorize(Roles = "Firma")]
    public class FirmaController : Controller
    {
        // GET: Firma
        //[AllowAnonymous] herkese açık alan
        public ActionResult Index()
        {
            var firma = new FirmaRepo().GetByUserId(HttpContext.User.Identity.GetUserId());
            FirmaViewModel model = null;
            if (firma != null)
                model = new FirmaViewModel()
                {
                    Id = firma.Id,
                    KullaniciId = firma.KullaniciId,
                    Adres = firma.Adres,
                    AktifMi = firma.AktifMi,
                    EklenmeTarihi = firma.EklenmeTarihi,
                    FirmaAdi = firma.FirmaAdi,
                    FirmaKapakFotoPath = firma.FirmaKapakFotoPath,
                    FirmaProfilFotoPath = firma.FirmaProfilFotoPath,
                    MinimumSiparisTutari = firma.MinimumSiparisTutari,
                    OrtalamaTeslimSuresi = firma.OrtalamaTeslimSuresi,
                    Telefon = firma.Telefon,
                    WebUrl = firma.WebUrl
                };
            return View(model);
        }

        public ActionResult Ekle()
        {
            var firma = new FirmaRepo().GetByUserId(HttpContext.User.Identity.GetUserId());
            if (firma != null)
            {
                ViewBag.durum = false;
                ViewBag.mesaj = "Zaten 1 adet firmanız var. Yeni firma ekleyemezsiniz!";
            }
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(FirmaViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                var firma = new Firma()
                {
                    KullaniciId = HttpContext.User.Identity.GetUserId(),
                    Adres = model.Adres,
                    AktifMi = model.AktifMi,
                    EklenmeTarihi = model.EklenmeTarihi,
                    FirmaAdi = model.FirmaAdi,
                    MinimumSiparisTutari = model.MinimumSiparisTutari,
                    OrtalamaTeslimSuresi = model.OrtalamaTeslimSuresi,
                    Telefon = model.Telefon,
                    WebUrl = model.WebUrl
                };
                new FirmaRepo().Insert(firma);
                if (model.FirmaProfilFotoFile != null && model.FirmaProfilFotoFile.ContentLength > 0)
                {
                    var file = model.FirmaProfilFotoFile;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = fileName?.Replace(" ", "");
                    fileName += Guid.NewGuid().ToString().Replace("-", "");
                    fileName = SiteSettings.UrlFormatConverter(fileName);
                    var klasorYolu = Server.MapPath("~/Upload/" + firma.Id);
                    var dosyaYolu = Server.MapPath("~/Upload/" + firma.Id + "/") + fileName + extName;
                    if (!Directory.Exists(klasorYolu))
                        Directory.CreateDirectory(klasorYolu);
                    file.SaveAs(dosyaYolu);
                    WebImage img = new WebImage(dosyaYolu);
                    //240x140
                    img.Resize(240, 140, false);
                    img.AddTextWatermark("Sefer Tası - BAU", "Tomato", opacity: 75, fontSize: 12, fontFamily: "Verdana",
                        horizontalAlign: "Left");
                    img.Save(dosyaYolu);
                    var ff = new FirmaRepo().GetById(firma.Id);
                    ff.FirmaProfilFotoPath = $"Upload/{firma.Id}/{fileName}{extName}";
                    new FirmaRepo().Update();
                }
                if (model.FirmaKapakFotoFile != null && model.FirmaKapakFotoFile.ContentLength > 0)
                {
                    var file = model.FirmaKapakFotoFile;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = fileName?.Replace(" ", "");
                    fileName += Guid.NewGuid().ToString().Replace("-", "");
                    fileName = SiteSettings.UrlFormatConverter(fileName);
                    var klasorYolu = Server.MapPath("~/Upload/" + firma.Id);
                    var dosyaYolu = Server.MapPath("~/Upload/" + firma.Id + "/") + fileName + extName;
                    if (!Directory.Exists(klasorYolu))
                        Directory.CreateDirectory(klasorYolu);
                    file.SaveAs(dosyaYolu);
                    WebImage img = new WebImage(dosyaYolu);
                    //1670x480
                    img.Resize(1670, 480, false);
                    img.AddTextWatermark("Sefer Tası - BAU", "Tomato", opacity: 75, fontSize: 26, fontFamily: "Verdana",
                        horizontalAlign: "Left");
                    img.Save(dosyaYolu);
                    var ff = new FirmaRepo().GetById(firma.Id);
                    ff.FirmaKapakFotoPath = $"Upload/{firma.Id}/{fileName}{extName}";
                    new FirmaRepo().Update();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }

        public ActionResult Duzenle()
        {
            var firma = new FirmaRepo().GetByUserId(HttpContext.User.Identity.GetUserId());
            FirmaViewModel model = null;
            if (firma != null)
                model = new FirmaViewModel()
                {
                    Id = firma.Id,
                    KullaniciId = firma.KullaniciId,
                    Adres = firma.Adres,
                    AktifMi = firma.AktifMi,
                    EklenmeTarihi = firma.EklenmeTarihi,
                    FirmaAdi = firma.FirmaAdi,
                    FirmaKapakFotoPath = firma.FirmaKapakFotoPath,
                    FirmaProfilFotoPath = firma.FirmaProfilFotoPath,
                    MinimumSiparisTutari = firma.MinimumSiparisTutari,
                    OrtalamaTeslimSuresi = firma.OrtalamaTeslimSuresi,
                    Telefon = firma.Telefon,
                    WebUrl = firma.WebUrl
                };
            else
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Duzenle(FirmaViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                var firma = new FirmaRepo().GetById(model.Id);
                firma.MinimumSiparisTutari = model.MinimumSiparisTutari;
                firma.OrtalamaTeslimSuresi = model.OrtalamaTeslimSuresi;
                firma.Telefon = model.Telefon;
                firma.Adres = model.Adres;
                if (model.FirmaProfilFotoFile != null && model.FirmaProfilFotoFile.ContentLength > 0)
                {
                    var file = model.FirmaProfilFotoFile;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = fileName?.Replace(" ", "");
                    fileName += Guid.NewGuid().ToString().Replace("-", "");
                    fileName = SiteSettings.UrlFormatConverter(fileName);
                    var klasorYolu = Server.MapPath("~/Upload/" + firma.Id);
                    var dosyaYolu = Server.MapPath("~/Upload/" + firma.Id + "/") + fileName + extName;
                    if (!Directory.Exists(klasorYolu))
                        Directory.CreateDirectory(klasorYolu);
                    file.SaveAs(dosyaYolu);
                    WebImage img = new WebImage(dosyaYolu);
                    //240x140
                    img.Resize(240, 140, false);
                    img.AddTextWatermark("Sefer Tası - BAU", "Tomato", opacity: 75, fontSize: 12, fontFamily: "Verdana",
                        horizontalAlign: "Left");
                    img.Save(dosyaYolu);
                    if (string.IsNullOrEmpty(firma.FirmaProfilFotoPath))
                    {
                        firma.FirmaProfilFotoPath = $"Upload/{firma.Id}/{fileName}{extName}";
                    }
                    else
                    {
                        System.IO.File.Delete(Server.MapPath(firma.FirmaProfilFotoPath));
                        firma.FirmaProfilFotoPath = $"Upload/{firma.Id}/{fileName}{extName}";
                    }
                    //ff.FirmaProfilFotoPath = $"Upload/{firma.Id}/{fileName}{extName}";
                    new FirmaRepo().Update();
                }
            }
            catch(Exception ex)
            {

            }
            return View();
        }
    }
}