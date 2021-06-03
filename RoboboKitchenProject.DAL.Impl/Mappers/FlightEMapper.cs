using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;
using WPF.Model.Models;

namespace WPF.DAL.Impl.Mappers
{
    public class FlightEMapper
    {
        public FlightEMapper()
        {

        }
        public Flight Map(FlightE flightE, UnitOfWork _unitOfWork)
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
        public List<Flight> Map(List<FlightE> flightE, UnitOfWork unitOfWork)
        {
            return flightE.Select(obj => Map(obj, unitOfWork)).ToList();
        }
    }
}
