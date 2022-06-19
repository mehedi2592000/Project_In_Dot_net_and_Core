using Core_Again_practice.Data;
using Core_Again_practice.InterfaceData;
using Core_Again_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_Again_practice.Repo
{
    public class ProductRepo : IRrepository<Product>
    {
        private readonly ApplicationDbContext _context;
           
       
        
        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
            
        }

        
        public Product Get()
        {
           throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> Catagories = _context.Products.ToList();

            return Catagories;
        }
    }
}
