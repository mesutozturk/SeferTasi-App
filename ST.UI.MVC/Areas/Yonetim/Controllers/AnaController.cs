using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ST.UI.MVC.Areas.Yonetim.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AnaController : Controller
    {
        // GET: Yonetim/Ana
        public ActionResult Index()
        {
            return View();
        }
    }
}