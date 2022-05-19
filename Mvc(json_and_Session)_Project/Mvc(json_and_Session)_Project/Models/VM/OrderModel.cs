using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_json_and_Session__Project.Models.VM
{
    public class OrderModel
    {
        public int id { get; set; }
        public int customerid { get; set; }
        public string status { get; set; }
    }
}