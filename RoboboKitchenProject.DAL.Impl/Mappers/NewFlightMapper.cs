using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.DAL.Abstract.Interface;
using WPF.Model.Models;
using WPF.Entity.Entities;

namespace WPF.DAL.Impl.Mappers
{
    public class NewFlightMapper : IMapper<Flight, FlightE>
    {
        public Flight Map(FlightE flightE)
        {
            return new Flight()
            {
                ID = flightE.ID,
                Name = flightE.Name,
                Time = flightE.Time,
                LastBuyTime = flightE.LastBuyTime,
                DelayTime = flightE.DelayTime
            };

        }
       
    }
}
