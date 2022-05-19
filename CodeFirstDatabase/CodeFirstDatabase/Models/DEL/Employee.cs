using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models.DEL
{
    public class Employee
    {
        [Key]
        public int emId { get; set; }

        public string empname { get; set; }

        public string address { get; set; }

        

    }
}