using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity;
using System.ComponentModel.DataAnnotations;
using System.Management.Automation;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF.Entity.Entities
{
    public class FlightE : IEntity<int>
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public DateTime LastBuyTime { get; set; }
        public TimeSpan DelayTime { get; set; }

       [AllowNull]
        public int? PlaneID { get; set; }

        [ForeignKey(nameof(PlaneID))]
        public PlaneE Plane { get; set; }


    }
}
