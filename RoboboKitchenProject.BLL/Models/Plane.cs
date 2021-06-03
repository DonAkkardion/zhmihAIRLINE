using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Models
{
    public class Plane
    {
        private int id;
        private string name;
        public string Name { get => name; set => name = value; }
        public int ID { get => id; set => id = value; }

        public Plane()
        {

        }
        public Plane(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
