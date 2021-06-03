using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WPF.DAL.Abstract
{

    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
