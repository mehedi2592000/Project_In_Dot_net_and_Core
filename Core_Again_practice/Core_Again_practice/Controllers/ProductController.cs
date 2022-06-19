using Core_Again_practice.Data;
using Core_Again_practice.InterfaceData;
using Core_Again_practice.Models;



using Core_Again_practice.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_Again_practice.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;
        private readonly IRrepository<Product> _unit;

        public ProductController(ApplicationDbContext context, IRrepository<Product> pro)
        {
            _context = context;
            _unit = pro;
            
        }

        public IActionResult Index()
        {
            // List<Product> Catagories = _unit.GetAll();

            List<Product> Catagories=_context.Products.ToList();
            return View(Catagories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
