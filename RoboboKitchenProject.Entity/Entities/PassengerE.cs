﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entity;
using System.ComponentModel.DataAnnotations;

namespace WPF.Entity.Entities
{
    public class PassengerE : IEntity<int>
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
