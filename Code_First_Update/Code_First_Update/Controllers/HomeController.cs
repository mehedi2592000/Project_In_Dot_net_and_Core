using Code_First_Update.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_Update.Controllers
{
    public class HomeController : Controller
    {
        DbEntities db = new DbEntities();
        public ActionResult Index()

        {
            var data = db.Orders.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}