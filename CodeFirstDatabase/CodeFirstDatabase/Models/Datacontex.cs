using CodeFirstDatabase.Models.DEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDatabase.Models
{
    public class Datacontex:DbContext
    {
        public Datacontex():base("conn")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDelail> OrderDelails { get; set; }
    }
}

//enable-migrations
//add-migration "ggo"
//update-database