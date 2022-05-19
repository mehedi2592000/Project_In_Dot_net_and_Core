using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models.DEL
{
    public class Class
    {
        public int classId { get; set; }
        public string name { get; set; }
        public int time { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}