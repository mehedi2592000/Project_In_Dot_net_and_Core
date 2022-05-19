using Code_First_Update.Models.DEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Update.Models
{
    public partial class DbEntities : DbContext
    {
        public DbEntities():base("conn")
        {

        }

        public DbSet<Order>Orders { get; set; }
        public DbSet<Orderdetail> Orderdetails { get; set; }

    }
}