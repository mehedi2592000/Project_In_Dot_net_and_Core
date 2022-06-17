using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyappData.Interfacture.IRrepository
{
    public interface Irepo<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetT(Expression<Func<T, bool>> predicate);

        void Add(T item);

        void Delete(T item);

        void DeleteRange(IEnumerable<T> items);

    }
}
