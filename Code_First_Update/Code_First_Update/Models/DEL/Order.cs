using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Update.Models.DEL
{
    public partial class Order
    {
        
        public Order()
        {
            this.Orderdetails = new HashSet<Orderdetail>();
        }

        [Key]
        public int OId { get; set; }
        

        public string Oname { get; set; }

        public int Taka { get; set; }

        public int Total { get; set; }

        public  int item { get; set; }

        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}