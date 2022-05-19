using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models.DEL
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string nameP { get; set; }
        public int price { get; set; }
        public int qty { get; set; }

    }
}