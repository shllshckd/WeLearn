﻿using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.ChatApp
{
    public class Message : BaseModel<int>
    {
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Text { get; set; }

        // public DateTime DateCreated { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }
    }
}