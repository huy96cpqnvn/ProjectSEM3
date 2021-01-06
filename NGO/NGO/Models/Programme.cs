using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Donate> Donates { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
