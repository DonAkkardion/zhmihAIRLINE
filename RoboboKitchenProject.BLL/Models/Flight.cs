using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Models
{
    public class Flight
    {
        private int _ID;
        private string _Name;
        private DateTime _Time;
        private DateTime _LastBuyTime;
        private TimeSpan _DelayTime;
        private string _DelayCause;
        private Plane _Plane;
        private List<Passenger> _listOfPassengers;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime Time { get => _Time; set => _Time = value; }
        public DateTime LastBuyTime { get => _LastBuyTime; set => _LastBuyTime = value; }
        public TimeSpan DelayTime { get => _DelayTime; set => _DelayTime = value; }
        public string DelayCause { get => _DelayCause; set => _DelayCause = value; }
        public List<Passenger> ListOfPassengers { get => _listOfPassengers; set => _listOfPassengers = value; }
        public Plane Plane { get => _Plane; set => _Plane = value; }

        public void AddPassenger(Passenger passenger)
        {
            this.ListOfPassengers.Add(passenger);
        }


        public Flight(string Name, DateTime Time, DateTime LastBuyTime, Plane Plane)
        {
            this.Name = Name;
            this.LastBuyTime = LastBuyTime;
            this.Time = Time;
            this.Plane = Plane;
            this.ListOfPassengers = new List<Passenger>();
        }

        public Flight()
        {

        }

        public List<string> GetPassengerList()
        {
            List<string> res = new List<string>();
            foreach (Passenger P in this.ListOfPassengers)
            {
                res.Add("Name: " + P.Name + " " + "Age: " + P.Age);
            }
            return res;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Time.ToString();
        }
    }
}
