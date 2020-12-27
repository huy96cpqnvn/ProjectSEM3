﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageAbout { get; set; }
        [MaxLength(10000)]
        public string Description { get; set; }
    }
}
