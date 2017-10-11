using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TravelBlog.Models
{


	[Table("Locations")]
    public class Location 
	{

        public Location()
        {
            this.Experiences = new HashSet<Experience>();
        }

		[Key]
		public int LocationId { get; set; }
		public string Country { get; set; }
        public string City { get; set; }
    
        public virtual ICollection<Experience> Experiences { get; set; }
	}
}
