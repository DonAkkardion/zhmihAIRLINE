using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.BL.Abstract.Interface
{
    public interface IFlightService <T> 
    {
        List<T> GetFlights();
    }
}
