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
    public class TicketE : IEntity<int>
    {
        [Key]
        public int ID { get; set; }

        [AllowNull]
        public int? FlightID { get; set; }

        [ForeignKey(nameof(FlightID))]
        public FlightE Flight { get; set; }

        [AllowNull]
        public int? PassengerID { get; set; }

        [ForeignKey(nameof(PassengerID))]
        public PassengerE Passenger { get; set; }
    }
}
