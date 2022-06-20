using Core_file_migration.Data;
using Core_file_migration.inter;
using Core_file_migration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Core_file_migration.Models.allmodel;

namespace Core_file_migration.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;
        private readonly IHostingEnvironment envio;
        private readonly IRrepository<Product> _unit;

        public ProductController(ApplicationDbContext context, IRrepository<Product> pro, IHostingEnvironment envio)
        {
            _context = context;
            _unit = pro;
            this.envio = envio; 

        }
        public IActionResult Index()
        {
            List<Product> products = _unit.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel p)
        {
            if (ModelState.IsValid)
            {
                var fullpath = Path.Combine(envio.ContentRootPath, @"wwwroot\Content\", p.ProductName.FileName);

                FileStream stream = new FileStream(fullpath, FileMode.Create);
                p.ProductName.CopyTo(stream);

                var data = new Product()
                {
                    Name = p.Name,
                    quantity = p.quantity,
                    ProductName = p.ProductName.FileName
                };
                _context.Add(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }

    }
}
