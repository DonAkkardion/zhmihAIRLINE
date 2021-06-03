using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.DAL.Abstract;
using WPF.DAL.Impl.Repository;

namespace WPF.DAL.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AirportContext _dataContext;
        private FlightERepository _FlightERepository;
        private PassengerERepository _PassengerERepository;
        private PlaneERepository _PlaneERepository;
        private TicketERepository _TicketERepository;


        public UnitOfWork(AirportContext context)
        {
            _dataContext = context;
        }

        public FlightERepository Flights
        {
            get
            {
                if (_FlightERepository == null)
                    _FlightERepository = new FlightERepository(_dataContext);
                return _FlightERepository;
            }
        }

        public PassengerERepository Passengers
        {
            get
            {
                if (_PassengerERepository == null)
                    _PassengerERepository = new PassengerERepository(_dataContext);
                return _PassengerERepository;
            }
        }
        public PlaneERepository Planes
        {
            get
            {
                if (_PlaneERepository == null)
                    _PlaneERepository = new PlaneERepository(_dataContext);
                return _PlaneERepository;
            }
        }

        public TicketERepository Tickets
        {
            get
            {
                if (_TicketERepository == null)
                    _TicketERepository = new TicketERepository(_dataContext);
                return _TicketERepository;
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
