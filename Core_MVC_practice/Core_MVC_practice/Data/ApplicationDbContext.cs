using Core_MVC_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_MVC_practice.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Catagory> Catagories { get; set; }
    }
}
