using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Ngo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Image Name")]
        public string ImageNgo { get; set; }
        public string Content { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }
        public virtual ICollection<Ngo> Ngos { get; set; }
    }
}
