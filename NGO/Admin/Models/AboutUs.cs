using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageAbout { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFileAbout { get; set; }


        [MaxLength(10000)]
        public string Description { get; set; }
    }
}
