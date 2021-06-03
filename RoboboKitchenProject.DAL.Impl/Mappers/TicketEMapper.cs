using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model.Models;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Mappers
{
    public class TicketEMapper : IMapper<Passenger, TicketE>
    {      
        public Passenger Map(TicketE ticketE)
        {
            return new Passenger()
            {

                ID = ticketE.Passenger.ID,
                Name = ticketE.Passenger.Name,
                Age = ticketE.Passenger.Age
            };

        }
     
    }
}
