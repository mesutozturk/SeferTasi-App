using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ST.UI.MVC.Controllers
{
    [Authorize(Roles = "Firma")]
    public class FirmaController : Controller
    {
        // GET: Firma
        public ActionResult Index()
        {
            return View();
        }
    }
}