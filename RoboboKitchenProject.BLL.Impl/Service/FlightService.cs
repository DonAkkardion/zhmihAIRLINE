using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.BL.Abstract.Interface;
using WPF.Model.Models;
using WPF.Entity.Entities;
using WPF.DAL.Impl.Mappers;
using WPF.DAL.Impl;
using WPF.DAL.Abstract.Interface;
using System.Management.Automation;

namespace WPF.BL.Impl.Service
{
    public class FlightService : IFlightService<Flight>
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper<Flight, FlightE> _mapper;
        public FlightService(UnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = new NewFlightMapper();

        }
        public List<Flight> GetFlights()
        {
            List<Flight> flights = new List<Flight>();
            flights = _unitOfWork.Flights.ListEntities().Select(_mapper.Map).ToList();
            return flights;
        }       
      
    }
}
