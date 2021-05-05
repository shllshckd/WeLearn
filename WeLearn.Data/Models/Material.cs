﻿using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Material : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Link { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
