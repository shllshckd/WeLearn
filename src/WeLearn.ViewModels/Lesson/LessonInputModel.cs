﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using WeLearn.ViewModels.Interfaces;
using static WeLearn.Data.Infrastructure.DataValidation.Lesson;

namespace WeLearn.ViewModels.Lesson
{
    public class LessonInputModel : ILessonModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please add name.")]
        [MaxLength(MaxNameLength)]
        public string LessonName { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please add description.")]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please pick a grade.")]
        public Grade Grade { get; set; }

        [Required(ErrorMessage = "Please provide a video.")]
        public IFormFile Video { get; set; }

        [Required(ErrorMessage = "Please provide one or more files, related to the lesson.")]
        public IEnumerable<IFormFile> Files { get; set; }
    }
}
