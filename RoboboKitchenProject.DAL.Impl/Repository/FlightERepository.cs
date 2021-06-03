using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Repository
{
    public class FlightERepository : GenericRepository<FlightE, int>, IFlightERepository
    {
        public FlightERepository(AirportContext context) : base(context)
        {

        }
    }
}
