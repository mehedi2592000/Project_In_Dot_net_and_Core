using Mvc_json_and_Session__Project.Models.EF;
using Mvc_json_and_Session__Project.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_json_and_Session__Project.Repo
{
    public class OrderRepo
    {
        static ProjectsEntities db;

        static OrderRepo()
        {
            db= new ProjectsEntities(); 
        }

        public static void Placeholder(List<ProductModel>products, int id)
        {
            Order oo = new Order();
            
                oo.customerid = id;
                oo.status = "ordered";
                db.Orders.Add(oo);
                db.SaveChanges();
                
            foreach(var p in products)
            {
                var od=new Orderdetail()
                {
                    productid=p.id,
                    unitprice=p.price,
                    qty=1,
                    orderid=oo.id
                };
                db.Orderdetails.Add(od);
                db.SaveChanges();
            }
            
        }



    }
}