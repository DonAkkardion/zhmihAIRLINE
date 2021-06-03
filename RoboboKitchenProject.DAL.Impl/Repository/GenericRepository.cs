using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.DAL.Abstract;
using System.Data.Entity;
using System.Linq.Expressions;

namespace WPF.DAL.Impl
{
    public abstract class GenericRepository<T,TKey> : IGenericRepository<T,TKey> where T : class
    {
        protected readonly AirportContext _dataContext;

        public GenericRepository(AirportContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            _dataContext.SaveChanges();
        }

        public T Get(TKey id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();

        }

        public List<T> ListEntities()
        {
            return _dataContext.Set<T>().ToList();
        }

        public List<T> ListEntities(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _dataContext.Entry<T>(entity).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }
    }
}
