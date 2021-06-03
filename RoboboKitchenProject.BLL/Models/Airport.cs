using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Models
{
    public class Airport
    {
        private List<Flight> listOfFlights;
        private List<Plane> listOfPlanes;
        private List<Passenger> listOfPassengers;

        public List<Flight> ListOfFlights { get => listOfFlights; set => listOfFlights = value; }
        public List<Plane> ListOfPlanes { get => listOfPlanes; set => listOfPlanes = value; }

        public List<Passenger> ListOfPassengers { get => listOfPassengers; set => listOfPassengers = value; }

        public Airport()
        {
            this.listOfFlights = new List<Flight>();
            this.listOfPlanes = new List<Plane>();
            this.listOfPassengers = new List<Passenger>();
        }
        public void AddFlight(Flight flight)
        {
            this.listOfFlights.Add(flight);
        }
        public void AddPlane(Plane plane)
        {
            this.listOfPlanes.Add(plane);
        }

        public Flight GetFlight(string Name)
        {
            Flight flight = new Flight();
            foreach (Flight F in listOfFlights)
            {
                if (F.Name == Name)
                {
                    flight = F;
                }
            }
            return flight;
        }
        public List<string> GetFlightNames()
        {
            List<string> FlightNames = new List<string>();

            foreach (Flight F in ListOfFlights)
            {
                FlightNames.Add(F.Name);
            }
            return FlightNames;
        }
        public void ChangeTime(string Name, TimeSpan DelayTime, DateTime LastBuyTime)
        {
            foreach (Flight F in ListOfFlights)
            {
                if (Name == F.Name)
                {
                    F.LastBuyTime = LastBuyTime;
                    F.DelayTime = DelayTime;
                }
            }

        }

    }
}
