using Mvc_json_and_Session__Project.Models.EF;
using Mvc_json_and_Session__Project.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_json_and_Session__Project.Repo
{
    public class ProductRepo
    {

        static  ProjectsEntities db;

        static ProductRepo()
        {
            db = new ProjectsEntities();
        }

        public static ProductModel Get(int id)
        {
            var p= (from pr in db.Products
                    where pr.id== id
                    select pr).FirstOrDefault();


            return new ProductModel()
            {
                id=p.id,
                name = p.name,
                price = p.price

            };
            
        }

         public static List<ProductModel>GetAll()
        {
            var products=new List<ProductModel>();

            foreach(var pr in db.Products)
            {
                ProductModel pm = new ProductModel()
                {
                    id = pr.id,
                    name = pr.name,
                    price = pr.price
                };
                products.Add(pm);

            }
            return products;
         }

        public static void Create(Product p)

        {
            db.Products.Add(p);
            db.SaveChanges();

           
            
        }
    }
}