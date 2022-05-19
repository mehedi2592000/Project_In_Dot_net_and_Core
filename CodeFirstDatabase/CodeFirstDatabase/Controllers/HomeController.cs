﻿using CodeFirstDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstDatabase.Controllers
{
    public class HomeController : Controller
    {
        Datacontex db = new Datacontex();
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
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