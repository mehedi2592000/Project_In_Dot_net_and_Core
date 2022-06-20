using Core_Again_practice.Data;
using Core_Again_practice.Models;
using Core_Again_practice.Models.ModelData;

using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Core_Again_practice.Controllers
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
        public IActionResult Create(CustomerModel cus)
        {
            if(ModelState.IsValid)
            {
                //var path = envio.WebRootPath;
                //var filepath = "/Content/" + cus.Imgname.FileName;
                //var fullpath=Path.Combine(path,filepath); 
              //  string folder="Content/";
                // folder += cus.Imgname.FileName + Guid.NewGuid().ToString();



                var fullpath = Path.Combine(envio.ContentRootPath,  @"wwwroot\Content\", cus.Imgname.FileName);


                //var fullpath = Path.Combine(envio.ContentRootPath, @"Pic\", cus.Imgname.FileName);





                //var fullpath = Path.Combine(envio.WebRootPath,folder);
                //   cus.Imgname.CopyToAsync(new FileStream(fullpath,FileMode.Create));  

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
//https://localhost:7282/