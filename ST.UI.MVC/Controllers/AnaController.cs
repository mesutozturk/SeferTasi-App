using ST.BLL.Repository;
using System.Linq;
using System.Web.Mvc;
using ST.Models.ViewModels;
using ST.BLL.Settings;

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


            //kategori
            //kategorinin ürünleri
            //firma bilgileri

            return View(firma);
        }
    }
}