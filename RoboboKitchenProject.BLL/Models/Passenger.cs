using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Models
{
    public class Passenger
    {
        private int _ID;
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int ID { get => _ID; set => _ID = value; }

        public Passenger()
        {

        }
        public Passenger(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age.ToString();
        }
    }
}
