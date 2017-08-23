using ST.BLL.Repository;
using ST.Models.Entities;
using ST.Models.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ST.UI.MVC.Areas.Yonetim.Controllers
{
    public class UrunKategoriController : Controller
    {
        // GET: Yonetim/UrunKategori
        public ActionResult Index()
        {
            return View();
        }

        #region JsonResults

        [HttpPost]
        public JsonResult Ekle(UrunKategoriViewModel model)
        {
            try
            {
                new UrunKategoriRepo().Insert(new UrunKategori()
                {
                    KategoriAdi = model.KategoriAdi,
                    Aciklama = model.Aciklama
                });
                var data = new
                {
                    success = true,
                    message = "Kategori ekleme işlemi başarılı"
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var data = new
                {
                    success = false,
                    message = "Kategori ekleme işlemi başarısız: " + ex.Message
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Getir()
        {
            var model = new UrunKategoriRepo().GetAll().OrderBy(x => x.KategoriAdi).Select(x => new UrunKategoriViewModel()
            {
                Id = x.Id,
                Aciklama = x.Aciklama,
                KategoriAdi = x.KategoriAdi
            }).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}