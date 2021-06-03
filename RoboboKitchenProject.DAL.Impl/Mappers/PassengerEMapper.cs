using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model.Models;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Mappers
{
    public class PassengerEMapper : IMapper<Passenger, PassengerE>
    {
   
        public Passenger Map(PassengerE passengerE)
        {
            return new Passenger()
            {
                ID = passengerE.ID,
                Name = passengerE.Name,
                Age = passengerE.Age
            };
        }
       
    }
}
