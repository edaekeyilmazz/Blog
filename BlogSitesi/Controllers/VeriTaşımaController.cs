using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class VeriTaşımaController : Controller
    {
        //
        // GET: /VeriTaşıma/

        public ActionResult Index()
        {
            ViewBag.Mesaj = "ViewBag üzrinden gönderilen mesaj";
            ViewData["Mesaj"] = "ViewData üzerinden gönderilen mesaj";
            TempData["Mesaj"] = "tempdata üzeirnden gönderilen mesaj";
            return new RedirectResult("~/Veritaşıma/Gonder");

        }
        public ActionResult Gonder()
        {
            return View();
        }
       
    }
}
