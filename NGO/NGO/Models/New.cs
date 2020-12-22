using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class New
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagesNew { get; set; }

        public int? ProgrameId { get; set; }
        public virtual Programme Programmes { get; set; }
    }
}
