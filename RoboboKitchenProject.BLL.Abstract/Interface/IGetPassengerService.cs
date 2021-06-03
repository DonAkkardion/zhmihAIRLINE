using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.BL.Abstract.Interface
{
    public interface IGetPassengerService <T>
    {
        List<T> GetPassenger();
    }
}
