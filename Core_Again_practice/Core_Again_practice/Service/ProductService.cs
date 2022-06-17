using Core_Again_practice.Models;
using Core_Again_practice.Repo;

namespace Core_Again_practice.Service
{
    public class ProductService
    {
        ProductRepo productRepo;

        public IEnumerable<Product>All()
        {
            var data = productRepo.GetAll();
            return data;
        }
    }
}
