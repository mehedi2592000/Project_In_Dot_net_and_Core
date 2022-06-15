using Mvc_json_and_Session__Project.Models.EF;
using Mvc_json_and_Session__Project.Models.VM;
using Mvc_json_and_Session__Project.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Mvc_json_and_Session__Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ProductRepo productRepo = new ProductRepo();    
            var p = ProductRepo.GetAll();

            return View(p);
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

        public ActionResult AddtoCart(int id)
        {
            var data=ProductRepo.Get(id);


            List<ProductModel> products;

            if(Session["cart"]==null)
            {
                products=new List<ProductModel>();
            }
            else
            {
                var json = Session["cart"].ToString();
                products=new JavaScriptSerializer().Deserialize<List<ProductModel>>(json);  
            }
            products.Add(data);
            var json2=new JavaScriptSerializer().Serialize(products);   
            Session["cart"]=json2;
            return RedirectToAction("Index");
        }

        public ActionResult Cart()
        {

            var json = Session["cart"].ToString();
            var products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json);
            return View(products);

        }

        public ActionResult Checkout()
        {
            var json = Session["cart"].ToString();
            var products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json);
            var id = 1;
            OrderRepo.Placeholder(products, id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if(ModelState.IsValid)
            {
                ProductRepo.Create(p);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}