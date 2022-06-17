using Core_migration.Data;

using Microsoft.AspNetCore.Mvc;
using Myapp.Models;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Catagory c)
        {
            if (ModelState.IsValid)
            {
                context.Catagories.Add(c);
                context.SaveChanges();
                TempData["success"] = "created successfully !";
                return RedirectToAction("Index");
            }
            return View(c);
        }

        [HttpGet]
        public IActionResult Edit(int? id)  //? null value allow na 
        {
            if(id==null || id==0)
            {
                return NotFound();
            }
            var c=context.Catagories.Find(id);
            if(c==null)
            {
                return NotFound();
            }

            return View(c);
        }
        [HttpPost]
        public IActionResult Edit(Catagory c)
        {
            if (ModelState.IsValid)
            {
                context.Catagories.Update(c);
                context.SaveChanges();
                TempData["success"] = "Edit successfully";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int? id)  //? null value allow na 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var c = (from e in context.Catagories
                     where e.Id == id
                     select e).FirstOrDefault();
            if (c == null)
            {
                return NotFound();
            }
            context.Catagories.Remove(c);
            context.SaveChanges();
            TempData["success"] = "Delete successfully";
            return View("Index");
        }
    }
}
