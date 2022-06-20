using Core_file_migration.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_file_migration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
