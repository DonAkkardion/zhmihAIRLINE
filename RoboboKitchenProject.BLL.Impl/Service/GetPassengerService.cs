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

namespace WPF.BL.Impl.Service
{
    public class GetPassengerService : IGetPassengerService<Passenger>
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IMapper<Passenger, PassengerE> _mapper;

        public GetPassengerService(UnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = new PassengerEMapper();

        }
        public List<Passenger> GetPassenger()
        {
            List<Passenger> passengers = new List<Passenger>();
            passengers = _unitOfWork.Passengers.ListEntities().Select(_mapper.Map).ToList();
            return passengers;

        }
    }
}
