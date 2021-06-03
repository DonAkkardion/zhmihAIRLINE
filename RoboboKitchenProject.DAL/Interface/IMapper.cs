using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.DAL.Abstract.Interface
{
    public interface IMapper<TModel, TEntity>
    {
        TModel Map(TEntity entity);
    }
}
