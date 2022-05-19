using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models.DEL
{
    public class OrderDelail
    {
        public int id { get; set; }
        public int orderid { get; set; }
        public string ordername { get; set; }
        public int price { get; set; }
        
    }
}