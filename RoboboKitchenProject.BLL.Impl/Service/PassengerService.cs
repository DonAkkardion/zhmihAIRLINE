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
    public class PassengerService : IPassengerService<Passenger, int>
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper<Passenger, TicketE> _mapper;
      
        public PassengerService(UnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
            this._mapper = new TicketEMapper();
        }
        public List<Passenger> GetPassengerWhereFlightID (int ID)
        {
            List<Passenger> passengers = new List<Passenger>();
            passengers = _unitOfWork.Tickets.GetWhereFlight(ID).Select(_mapper.Map).ToList();
            return passengers;
        }

    }
}
