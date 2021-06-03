using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace WPF.DAL.Abstract
{
    public interface IGenericRepository<T,TKey> where T : class
    {
        T Get(TKey id);
        List<T> ListEntities();
        List<T> ListEntities(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
