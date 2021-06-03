using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WPF.Entity.Entities;
using System.Data.Entity;
using WPF.Model.Models;

namespace WPF.DAL.Impl
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base(ConfigurationManager.ConnectionStrings["Standart"].ConnectionString)
        {

        }


        public DbSet<FlightE> Flights { get; set; }
        public DbSet<PassengerE> Passengers { get; set; }
        public DbSet<PlaneE> Planes { get; set; }
        public DbSet<TicketE> Tickets { get; set; }
    }
}
