using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models.DEL
{
    public class Student
    {
        public int Sid { get; set; }
        public string SName { get; set; }
        public int Fname { get; set; }

        public int CId { get; set; }

        public virtual Class pop { get; set; }
    }
}