using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Repository
{
    public class TicketERepository : GenericRepository<TicketE, int>, ITicketERepository
    {
        public TicketERepository(AirportContext context) : base(context)
        {

        }
        public IEnumerable<TicketE> GetWhereFlight(int ID)
        {
            return this.ListEntities(obj => obj.FlightID == ID);
        }
    }
}
