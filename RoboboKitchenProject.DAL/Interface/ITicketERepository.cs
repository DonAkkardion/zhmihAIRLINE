using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;

namespace WPF.DAL.Abstract.Interface
{
    public interface ITicketERepository : IGenericRepository<TicketE, int>
    {
        //List<TicketE> GetWhereFlightID(int ID);
        IEnumerable<TicketE> GetWhereFlight(int ID);
    }
}
