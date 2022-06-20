using Core_file_migration.Data;
using Core_file_migration.inter;
using Core_file_migration.Models;

namespace Core_file_migration.Repo
{
    public class ProductRepo : IRrepository<Product>
    {

        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Product ent)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }
    }
}
