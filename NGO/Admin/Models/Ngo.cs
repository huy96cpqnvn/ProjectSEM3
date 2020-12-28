﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Ngo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageNgo { get; set; }
        [MaxLength(10000)]
        public string Description { get; set; }
    }
}