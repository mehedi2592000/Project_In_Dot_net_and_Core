using Core_file_migration.Data;
using Core_file_migration.Models;
using Core_file_migration.Models.allmodel;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
namespace Core_file_migration.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;
        private readonly IHostingEnvironment envio;

        public CustomerController(ApplicationDbContext context, IHostingEnvironment envio)

        {
            _context = context;
            this.envio = envio;
        }

        public IActionResult Index()
        {
            var data = _context.Customers.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerModel cus )
        {
            if(ModelState.IsValid)
            {
                var fullpath = Path.Combine(envio.ContentRootPath, @"wwwroot\Content\", cus.Imgname.FileName);
                FileStream stream = new FileStream(fullpath, FileMode.Create);
                cus.Imgname.CopyTo(stream);

                var data = new Customer()
                {
                    Name = cus.Name,
                    Imgname = cus.Imgname.FileName,
                    num = cus.num
                };
                _context.Add(data);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(cus);
            }
        }
    }
}
