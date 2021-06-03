using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity.Entities;
using WPF.DAL.Abstract.Interface;

namespace WPF.DAL.Impl.Repository
{
    public class PlaneERepository : GenericRepository<PlaneE, int>, IPlaneERepository
    {
        public PlaneERepository(AirportContext context) : base(context)
        {

        }
    }
}
