using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Image Name")]
        public string ImagesProgram { get; set; }
        public string Content { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual ICollection<Donate> Donates { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}
