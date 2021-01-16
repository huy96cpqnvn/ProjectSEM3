using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Programme
    {
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "Programe Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagesProgram { get; set; }
        public virtual ICollection<Donate> Donates { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}
