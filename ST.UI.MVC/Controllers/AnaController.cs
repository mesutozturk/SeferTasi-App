using ST.BLL.Repository;
using System.Linq;
using System.Web.Mvc;
using ST.Models.ViewModels;
using ST.BLL.Settings;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace ST.UI.MVC.Controllers
{
    public class AnaController : Controller
    {
        // GET: Ana
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Restoranlar()
        {
            var model = new FirmaRepo().GetAll().Where(x => x.AktifMi)
                .Select(x => new FirmaViewModel()
                {
                    Id = x.Id,
                    Adres = x.Adres,
                    EklenmeTarihi = x.EklenmeTarihi,
                    FirmaAdi = x.FirmaAdi,
                    FirmaKapakFotoPath = x.FirmaKapakFotoPath,
                    FirmaProfilFotoPath = x.FirmaProfilFotoPath,
                    MinimumSiparisTutari = x.MinimumSiparisTutari,
                    OrtalamaTeslimSuresi = x.OrtalamaTeslimSuresi,
                    Telefon = x.Telefon
                })
                .OrderBy(x => x.MinimumSiparisTutari)
                .ThenBy(x => x.OrtalamaTeslimSuresi)
                .ToList();
            return View(model);
        }
        [AllowAnonymous]
        [Route("~/Aciktim/{baslik}-lokanta/{id?}")]
        public ActionResult Detay(int? id, string baslik)
        {
            if (id == null)
                return RedirectToAction("Restoranlar");

            var firma = new FirmaRepo().GetById(id.Value);
            if (firma == null)
                return RedirectToAction("Restoranlar");

            string basliktest = SiteSettings.UrlFormatConverter(firma.FirmaAdi);
            if (basliktest.ToLower() != baslik.ToLower())
                return RedirectToAction("Detay", new { id = firma.Id, baslik = basliktest });

            ViewBag.firmaid = firma.Id;
            //kategori
            //kategorinin ürünleri
            //firma bilgileri

            return View(firma);
        }
        public JsonResult FirmaninUrunleriniGetir(int id)
        {
            var firma = new FirmaRepo().GetById(id);
            if (firma == null)
            {
                return Json(new
                {
                    success = false,
                    message = "Firma Bulunamadı"
                }, JsonRequestBehavior.AllowGet);
            }
            var urunmodel = new List<FirmaUrunKategoriViewModel>();
            new FirmaUrunRepo()
                .GetAll()
                .Where(x => x.SatistaMi = true && x.FirmaId == firma.Id)
                .ToList().ForEach(x =>
                    urunmodel.Add(new FirmaUrunKategoriViewModel
                    {
                        FiyatGorunum = $"{x.UrunFiyat:c2}",
                        Fiyat = x.UrunFiyat,
                        UrunId = x.UrunId,
                        UrunAdi = x.Urun.UrunAdi,
                        UrunResimPath = x.Urun.UrunFotografYolu,
                        KategoriAdi = x.Urun.UrunKategori.KategoriAdi,
                        KategoriAciklama = x.Urun.UrunKategori.Aciklama
                    })
                );


            var firmaUrunModel = new FirmaUrunleriViewModel()
            {
                Id = firma.Id,
                FirmaAdi = firma.FirmaAdi,
                MinimumSiparisTutari = firma.MinimumSiparisTutari,
                OrtalamaSiparisSuresi = firma.OrtalamaTeslimSuresi,
                Urunler = urunmodel.OrderBy(x => x.KategoriAdi).ToList()
            };


            var data = new
            {
                success = true,
                data = firmaUrunModel
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult OdemeTipleriniGetir()
        {
            var data = new OdemeTipiRepo().GetAll().Select(x => new { x.Id, x.OdemeTipiAdi }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Authorize]
        public ActionResult SepetiOnayla(SepetViewModel model)
        {
            model.KullaniciId = HttpContext.User.Identity.GetUserId();
            new SiparisRepo().Insert(model);
            return RedirectToAction("Profilim", "Hesap");
        }
    }
}