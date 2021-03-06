﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TravelBlog.Models
{
    [Table("People")]
    public class Person
    {

        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }

        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }

    }
}
