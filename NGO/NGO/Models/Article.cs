﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImagesNew { get; set; }
        public string Content { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        public int? ProgrammeId { get; set; }
        public virtual Programme Programmes { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
