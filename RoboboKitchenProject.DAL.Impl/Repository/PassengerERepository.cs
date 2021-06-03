using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Repository
{
    public class PassengerERepository : GenericRepository<PassengerE, int>, IPassengerERepository
    {
        public PassengerERepository(AirportContext context) : base(context)
        {

        }
    }
}
