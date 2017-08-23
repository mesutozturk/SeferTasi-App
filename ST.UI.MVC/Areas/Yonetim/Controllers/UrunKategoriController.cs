using ST.BLL.Repository;
using ST.Models.Entities;
using ST.Models.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ST.UI.MVC.Areas.Yonetim.Controllers
{
    [Authorize(Roles = "Admin")]
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

        [HttpPost]
        public JsonResult Guncelle(UrunKategoriViewModel model)
        {
            try
            {
                var kategori = new UrunKategoriRepo().GetById(model.Id);
                kategori.KategoriAdi = model.KategoriAdi;
                kategori.Aciklama = model.Aciklama;
                new UrunKategoriRepo().Update();
                var data = new
                {
                    success = true,
                    message = "Kategori Güncelleme işlemi başarılı"
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var data = new
                {
                    success = false,
                    message = "Kategori Güncelleme işlemi başarısız: " + ex.Message
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Sil(int? id)
        {
            try
            {
                var kategori = new UrunKategoriRepo().GetById(id.Value);
                new UrunKategoriRepo().Delete(kategori);
                var data = new
                {
                    success = true,
                    message = "Kategori Silme işlemi başarılı"
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var data = new
                {
                    success = false,
                    message = "Kategori Silme işlemi başarısız :" + ex.Message
                };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion
    }
}