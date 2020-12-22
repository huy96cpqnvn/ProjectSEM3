﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Donate
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int? ProgrammeId { get; set; }
        public virtual Programme Programmes { get; set; }
        public DateTime DateDonate { get; set; }
        public string Description { get; set; }
    }
}
