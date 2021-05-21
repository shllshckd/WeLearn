﻿using System.ComponentModel.DataAnnotations;

namespace WeLearn.Data.Models.Base
{
    public class SoftDeleteable : Identifiable
    {
        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
    }
}