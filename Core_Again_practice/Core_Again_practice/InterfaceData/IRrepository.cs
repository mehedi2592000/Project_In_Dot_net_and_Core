
using Core_Again_practice.Models;

namespace Core_Again_practice.InterfaceData
{
    public interface IRrepository
    {
        List<Product> GetAll();

        Product Get();

        
    }
}
