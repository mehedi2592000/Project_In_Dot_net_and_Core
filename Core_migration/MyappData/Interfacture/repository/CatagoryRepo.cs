using Core_migration.Data;
using Microsoft.EntityFrameworkCore;
using MyappData.Interfacture.IRrepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyappData.Interfacture.repository
{
    public class CatagoryRepo<T> : Irepo<T> where T : class
    {

        private readonly ApplicationDbContext _Context;
        private DbSet<T> _dbSet;

        public CatagoryRepo(ApplicationDbContext context)
        {
            _Context = context;
            _dbSet = _Context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            _dbSet.RemoveRange(items);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetT(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }
    }
}
