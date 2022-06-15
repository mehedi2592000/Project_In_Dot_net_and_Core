using Core_migration.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_migration.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<Catagory> Catagories { get; set; }
    }
}
