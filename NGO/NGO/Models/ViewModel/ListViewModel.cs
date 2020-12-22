﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models.ViewModel
{
    public class ListViewModel
    {
        public IEnumerable<Donate> Donates{get; set;}
        public IEnumerable<Programme> Programmes { get; set; }
        public IEnumerable<New> News { get; set; }
        public IEnumerable<Gallery> Galleries { get; set; }
    }
}