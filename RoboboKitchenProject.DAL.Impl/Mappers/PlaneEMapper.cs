using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model.Models;
using WPF.Entity.Entities;


namespace WPF.DAL.Impl.Mappers
{
    public class PlaneEMapper
    {
        public PlaneEMapper()
        {

        }

        public Plane Map (PlaneE planeE, UnitOfWork _UnitOfWork)
        {
            return new Plane()
            {
                ID = planeE.ID,
                Name = planeE.Name
            };
        }

    }
}
