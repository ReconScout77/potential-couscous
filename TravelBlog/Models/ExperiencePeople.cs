using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TravelBlog.Models
{
    [Table("ExperiencePeople")]
    public class ExperiencePerson
    {
        [Key]
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }

        public int PersonId { get; set;  }
        public virtual Person Person { get; set; }
    }
}
