using ST.BLL.Repository;
using System.Web.Mvc;
using ST.Models.ViewModels;
using System;
using System.Linq;

namespace ST.UI.MVC.Areas.Yonetim.Controllers
{
    public class FirmaYonetimController : Controller
    {
        // GET: Yonetim/FirmaYonetim
        public ActionResult Index()
        {
            return View();
        }
        #region JsonResults

        [HttpGet]
        public JsonResult Getir()
        {
            var model = new FirmaRepo().GetAll()
                .OrderByDescending(x => x.EklenmeTarihi)
                .Select(x => new FirmaViewModel()
                {
                    Id = x.Id,
                    Adres = x.Adres,
                    AktifMi = x.AktifMi,
                    EklenmeTarihi = x.EklenmeTarihi,
                    FirmaAdi = x.FirmaAdi,
                    FirmaKapakFotoPath = x.FirmaKapakFotoPath,
                    FirmaProfilFotoPath = x.FirmaProfilFotoPath,
                    KullaniciId = x.KullaniciId,
                    KullaniciAdi = x.Kullanicisi.UserName,
                    MinimumSiparisTutari = x.MinimumSiparisTutari,
                    OrtalamaTeslimSuresi = x.OrtalamaTeslimSuresi,
                    Telefon = x.Telefon,
                    WebUrl = x.WebUrl
                }).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guncelle(FirmaViewModel model)
        {
            try
            {
                var firma = new FirmaRepo().GetById(model.Id);
                firma.AktifMi = model.AktifMi;
                firma.MinimumSiparisTutari = model.MinimumSiparisTutari;
                firma.OrtalamaTeslimSuresi = model.OrtalamaTeslimSuresi;
                firma.FirmaAdi = model.FirmaAdi;
                new FirmaRepo().Update();
                var data = new
                {
                    success = true,
                    message = "Firma Güncelleme işlemi başarılı"
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var data = new
                {
                    success = false,
                    message = "Firma Güncelleme işlemi başarısız: " + ex.Message
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        
        #endregion
    }
}