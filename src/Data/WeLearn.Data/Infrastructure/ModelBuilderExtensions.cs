﻿using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Common;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Data.Infrastructure
{
    public static class ModelBuilderExtensions
    {

        // todo: move seeding method
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1, ApplicationUserId = GlobalConstants.SeededUserId, Content = "I like it!",
                    LessonId = 1
                },
                new Comment
                {
                    Id = 2, ApplicationUserId = GlobalConstants.SeededUserId,
                    Content = "The teacher is awesome.", LessonId = 2
                },
                new Comment
                {
                    Id = 3, ApplicationUserId = GlobalConstants.SeededUserId,
                    Content = "This is just great.", LessonId = 3
                });

            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    Id = 1, ApplicationUserId = GlobalConstants.SeededUserId, LessonId = 5,
                    Subject = "The language used in title", Description = "Bad language in lesson's title."
                },
                new Report
                {
                    Id = 3, ApplicationUserId = GlobalConstants.SeededUserId, CommentId = 1,
                    Subject = "Unacceptable behaviour", Description = "Bad language in comment."
                });

            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, CreatedOn = DateTime.UtcNow, Name = "Bulgarian Language"},
                new Category {Id = 2, CreatedOn = DateTime.UtcNow, Name = "Mathematics"},
                new Category {Id = 3, CreatedOn = DateTime.UtcNow, Name = "Informatics"},
                new Category {Id = 4, CreatedOn = DateTime.UtcNow, Name = "IT"},
                new Category {Id = 5, CreatedOn = DateTime.UtcNow, Name = "Geography"},
                new Category {Id = 6, CreatedOn = DateTime.UtcNow, Name = "Physical Education and Sport"},
                new Category {Id = 7, CreatedOn = DateTime.UtcNow, Name = "Literature"},
                new Category {Id = 8, CreatedOn = DateTime.UtcNow, Name = "Civic Education"},
                new Category {Id = 9, CreatedOn = DateTime.UtcNow, Name = "English Language"},
                new Category {Id = 10, CreatedOn = DateTime.UtcNow, Name = "Russian Language"},
                new Category {Id = 11, CreatedOn = DateTime.UtcNow, Name = "History"},
                new Category {Id = 12, CreatedOn = DateTime.UtcNow, Name = "Biology"},
                new Category {Id = 13, CreatedOn = DateTime.UtcNow, Name = "Chemistry"},
                new Category {Id = 14, CreatedOn = DateTime.UtcNow, Name = "Music"},
                new Category {Id = 15, CreatedOn = DateTime.UtcNow, Name = "Art"},
                new Category {Id = 16, CreatedOn = DateTime.UtcNow, Name = "Technologies and Entrepreneurship"},
                new Category {Id = 17, CreatedOn = DateTime.UtcNow, Name = "Others"});

            modelBuilder.Entity<Video>().HasData(
                new Video
                {
                    Id = 1, LessonId = 1, ContentType = "video/mp4", Name = "Teaching",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622056204/welearn-asp-net-core-app/videos/seed/teacher-presenting.mp4"
                },
                new Video
                {
                    Id = 2, LessonId = 2, ContentType = "video/mp4", Name = "Teaching",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053205/welearn-asp-net-core-app/videos/seed/man-teaching_miueor.mp4"
                },
                new Video
                {
                    Id = 3, LessonId = 3, ContentType = "video/mp4", Name = "Coding",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053215/welearn-asp-net-core-app/videos/seed/coding_bbc9sv.mp4"
                },
                new Video
                {
                    Id = 4, LessonId = 4, ContentType = "video/mp4",
                    Name = "Office Suite",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053172/welearn-asp-net-core-app/videos/seed/office-suite_lugjnz.mp4"
                },
                new Video
                {
                    Id = 5, LessonId = 5, ContentType = "video/mp4", Name = "Ukraine",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053238/welearn-asp-net-core-app/videos/seed/eastern-europe_a7ljx0.mp4"
                },
                new Video
                {
                    Id = 6, LessonId = 6, ContentType = "video/mp4", Name = "Football",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053255/welearn-asp-net-core-app/videos/seed/football_basmoc.mp4"
                },
                new Video
                {
                    Id = 7, LessonId = 7, ContentType = "video/mp4", Name = "Literature",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053256/welearn-asp-net-core-app/videos/seed/literature_u1mriv.mp4"
                },
                new Video
                {
                    Id = 8, LessonId = 8, ContentType = "video/mp4",
                    Name = "Human Rights",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053261/welearn-asp-net-core-app/videos/seed/human-rights_vbojip.mp4"
                },
                new Video
                {
                    Id = 9, LessonId = 9, ContentType = "video/mp4",
                    Name = "Modal Verbs",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053183/welearn-asp-net-core-app/videos/seed/modal-verbs_jjnya3.mp4"
                },
                new Video
                {
                    Id = 10, LessonId = 10, ContentType = "video/mp4",
                    Name = "Russian Language",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053192/welearn-asp-net-core-app/videos/seed/russian-language_uaydhx.mp4"
                },
                new Video
                {
                    Id = 11, LessonId = 11, ContentType = "video/mp4", Name = "History",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053246/welearn-asp-net-core-app/videos/seed/history_sll9r9.mp4"
                },
                new Video
                {
                    Id = 12, LessonId = 12, ContentType = "video/mp4", Name = "Biology",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053200/welearn-asp-net-core-app/videos/seed/biology_veyt5f.mp4"
                },
                new Video
                {
                    Id = 13, LessonId = 13, ContentType = "video/mp4",
                    Name = "Chemistry",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053225/welearn-asp-net-core-app/videos/seed/chemistry_zpdwl9.mp4"
                },
                new Video
                {
                    Id = 14, LessonId = 14, ContentType = "video/mp4", Name = "Music",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053175/welearn-asp-net-core-app/videos/seed/music_x6vt4y.mp4"
                },
                new Video
                {
                    Id = 15, LessonId = 15, ContentType = "video/mp4", Name = "Painting",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053181/welearn-asp-net-core-app/videos/seed/painting_glxyu0.mp4"
                },
                new Video
                {
                    Id = 16, LessonId = 16, ContentType = "video/mp4",
                    Name = "Entrepreneurship",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053249/welearn-asp-net-core-app/videos/seed/entrepreneurship_ulreso.mp4"
                });

            modelBuilder.Entity<Lesson>().HasData(
                new Lesson
                {
                    Id = 1, VideoId = 1, MaterialId = 1, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 1, Grade = Grade.First, Name = "Pronouns, types",
                    Description = "A lecture about pronouns and when to use them."
                },
                new Lesson
                {
                    Id = 2, VideoId = 2, MaterialId = 2, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 2, Grade = Grade.Second, CreatedOn = DateTime.UtcNow, Name = "Prime numbers",
                    Description =
                        "A natural number greater than 1 that is not a product of two smaller natural numbers."
                },
                new Lesson
                {
                    Id = 3, VideoId = 3, MaterialId = 3, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 3, Grade = Grade.Third, Name = "Developing with C#",
                    Description = "About the C# language and the .NET development Platform. First steps."
                },
                new Lesson
                {
                    Id = 4, VideoId = 4, MaterialId = 4, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 4, Grade = Grade.Fourth, CreatedOn = DateTime.UtcNow, Name = "Excel",
                    Description = "Data analysis."
                },
                new Lesson
                {
                    Id = 5, VideoId = 5, MaterialId = 5, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 5, Grade = Grade.Fifth,
                    Name = "Ukraine, Eastern Europe",
                    Description = "Eastern European Countries. Their economic growth and political stances. Ukraine."
                },
                new Lesson
                {
                    Id = 6, VideoId = 6, MaterialId = 6, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 6, Grade = Grade.Sixth, Name = "Football",
                    Description = "Kicking a ball on the field."
                },
                new Lesson
                {
                    Id = 7, VideoId = 7, MaterialId = 7, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 7, Grade = Grade.Seventh,
                    Name = "William Shakespeare's 106 sonnet", Description = "A peek into Shakespeare's art."
                },
                new Lesson
                {
                    Id = 8, VideoId = 8, MaterialId = 8, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 8, Grade = Grade.Eighth, Name = "Human rights",
                    Description = "A lecture about rights of the people."
                },
                new Lesson
                {
                    Id = 9, VideoId = 9, MaterialId = 9, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 9, Grade = Grade.Ninth, Name = "Modal verbs",
                    Description = "We use modals to show if we believe something is certain, possible or impossible."
                },
                new Lesson
                {
                    Id = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 10, Grade = Grade.Tenth, Name = "Verbs of motion",
                    Description = "A lecture about the verbs of motion and when to use them."
                },
                new Lesson
                {
                    Id = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 11, Grade = Grade.Eleventh, Name = "Peek in the past",
                    Description = "A brief peek into our ancestors' life."
                },
                new Lesson
                {
                    Id = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 12, Grade = Grade.Twelfth,
                    Name = "Cells. Prokaryotic and Eukaryotic",
                    Description = "A lesson about the different types of cells and their differences."
                },
                new Lesson
                {
                    Id = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 13, Grade = Grade.Mixed, Name = "Acids, Bases and pH",
                    Description = "A lesson about acids, they effects on the environtment and usage cases."
                },
                new Lesson
                {
                    Id = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 14, Grade = Grade.Fifth, Name = "Popular music",
                    Description = "Genres, instruments and notation."
                },
                new Lesson
                {
                    Id = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 15, Grade = Grade.First, Name = "Painting",
                    Description = "Pigments, brushes, bases, matrices."
                },
                new Lesson
                {
                    Id = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = GlobalConstants.SeededUserId,
                    IsApproved = true,
                    CategoryId = 16, Grade = Grade.Second, Name = "Entrepreneurship",
                    Description = "Creating a new business, bearing most of the risks and enjoying most of the rewards."
                });

            modelBuilder.Entity<Material>().HasData(
                new Material
                {
                    Id = 1, LessonId = 1, Name = "Teaching",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 2, LessonId = 2, Name = "Teaching",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 3, LessonId = 3, Name = "Coding",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 4, LessonId = 4, Name = "Office Suite",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 5, LessonId = 5, Name = "Ukraine",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 6, LessonId = 6, Name = "Football",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 7, LessonId = 7, Name = "Literature",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 8, LessonId = 8, Name = "Human Rights",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 9, LessonId = 9, Name = "Modal Verbs",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 10, LessonId = 10, Name = "Russian Language",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 11, LessonId = 11, Name = "History",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 12, LessonId = 12, Name = "Biology",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 13, LessonId = 13, Name = "Chemistry",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 14, LessonId = 14, Name = "Music",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 15, LessonId = 15, Name = "Painting",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                },
                new Material
                {
                    Id = 16, LessonId = 16, Name = "Entrepreneurship",
                    Link =
                        "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                });
        }
    }
}