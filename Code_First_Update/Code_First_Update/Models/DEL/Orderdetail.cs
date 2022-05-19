using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Update.Models.DEL
{
    public class Orderdetail
    {
        [Key]
        public int Did { get; set; }
        public string Name { get; set; }
        public int money { get; set; }
        public int OrdeId { get; set; }

        public virtual Order Order { get; set; }
    }
}