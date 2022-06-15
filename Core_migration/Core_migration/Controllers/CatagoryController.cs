using Core_migration.Data;
using Core_migration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_migration.Controllers
{
    public class CatagoryController : Controller
    {
        private ApplicationDbContext context;

        public CatagoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Catagory>pass=context.Catagories;

            return View(pass);
        }
    }
}
