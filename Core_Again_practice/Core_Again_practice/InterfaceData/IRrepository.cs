
using Core_Again_practice.Models;

namespace Core_Again_practice.InterfaceData
{
    public interface IRrepository<T>
    {
        List<T> GetAll();

        Product Get();

        
    }
}
