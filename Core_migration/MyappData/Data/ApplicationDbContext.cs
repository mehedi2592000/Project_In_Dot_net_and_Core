
using Microsoft.EntityFrameworkCore;
using Myapp.Models;

namespace Core_migration.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<User> Users { get; set; }
        public object Catagory { get; set; }
    }
}
