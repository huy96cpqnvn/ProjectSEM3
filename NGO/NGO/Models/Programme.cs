﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Donate> Donates { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
