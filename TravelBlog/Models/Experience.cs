using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Story { get; set; }
        public DateTime EarthTime { get; set; }


        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
