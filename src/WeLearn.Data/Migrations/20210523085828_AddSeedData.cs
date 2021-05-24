﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "206afdd1-c40a-48fc-80ab-244ec0453c23", "default@gmail.com", false, false, null, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAEAqSH6bqN29koBmFOc0puAPii4EIQqqBw1Gug6wI2j9KY5MumQq6fuUuoOvQRqg0eQ==", null, false, "d38de91e-7d0b-47dd-880f-54b86942f2b8", false, "Username" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 15, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2200), false, "Art" },
                    { 14, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2199), false, "Music" },
                    { 13, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2198), false, "Chemistry" },
                    { 12, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2196), false, "Biology" },
                    { 11, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2195), false, "History" },
                    { 10, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2194), false, "Russian Language" },
                    { 9, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2192), false, "English Language" },
                    { 8, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2191), false, "Civic Education" },
                    { 7, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2189), false, "Literature" },
                    { 6, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2187), false, "Physical Education and Sport" },
                    { 5, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2186), false, "Geography" },
                    { 4, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2184), false, "IT" },
                    { 3, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2183), false, "Informatics" },
                    { 2, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2179), false, "Mathematics" },
                    { 1, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(1251), false, "Bulgarian Language" },
                    { 16, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2202), false, "Technologies and Entrepreneurship" },
                    { 17, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2203), false, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "Description", "Grade", "IsApproved", "IsDeleted", "MaterialId", "Name", "VideoId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(8323), "A lecture about pronouns and when to use them.", 1, true, false, 1, "Pronouns, types", 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9626), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 2, true, false, 2, "Prime numbers", 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9629), "About the C# language and the .NET development Platform. First steps.", 3, true, false, 3, "Developing with C#", 3 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9632), "Data analysis.", 4, true, false, 4, "Excel", 4 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9634), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 5, true, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9635), "Kicking a ball on the field.", 6, true, false, 6, "Football", 6 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9637), "A peek into Shakespere's art.", 7, true, false, 7, "William Shakespere's 106 sonnet", 7 },
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9639), "A lecture about rights of the people.", 8, true, false, 8, "Human rights", 8 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9642), "We use modals to show if we believe something is certain, possible or impossible.", 9, true, false, 9, "Modal verbs", 9 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9643), "A lecture about the verbs of motion and when to use them.", 10, true, false, 10, "Verbs of motion", 10 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9645), "A brief peek into our ancestors' life.", 11, true, false, 11, "Peek in the past", 11 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9648), "A lesson about the different types of cells and their differences.", 12, true, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9652), "A lesson about acids, they effects on the environtment and usage cases.", 0, true, false, 13, "Acids, Bases and pH", 13 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9654), "Genres, instruments and notation.", 5, true, false, 14, "Popular music", 14 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9657), "Pigments, brushes, bases, matrices.", 1, true, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9660), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 2, true, false, 16, "Entrepreneurship", 16 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "IsDeleted", "LessonId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "I like it!", new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(4463), false, 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "The teacher is awesome.", new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(6336), false, 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "This is just great.", new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(6340), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2067), false, 10, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Russian Language", null },
                    { 12, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2069), false, 12, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Biology", null },
                    { 9, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2065), false, 9, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Modal Verbs", null },
                    { 8, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2064), false, 8, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Human Rights", null },
                    { 16, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2074), false, 16, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Entrepreneurship", null },
                    { 7, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2063), false, 7, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Literature", null },
                    { 13, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2070), false, 13, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Chemistry", null },
                    { 6, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2061), false, 6, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Football", null },
                    { 11, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2068), false, 11, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "History", null },
                    { 14, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2072), false, 14, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Music", null },
                    { 4, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2058), false, 4, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Office Suite", null },
                    { 3, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2056), false, 3, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Coding", null },
                    { 15, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2073), false, 15, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Painting", null },
                    { 2, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2054), false, 2, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 1, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(728), false, 1, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 5, new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2060), false, 5, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Ukraine", null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(7468), "Bad language in lesson's title.", false, 5, "The language used in title" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "ContentType", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 11, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5104), false, 11, "/uploads/videos/history.mp4", "History", null },
                    { 13, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5111), false, 13, "/uploads/videos/chemistry.mp4", "Chemistry", null },
                    { 14, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5113), false, 14, "/uploads/videos/music.mp4", "Music", null },
                    { 12, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5110), false, 12, "/uploads/videos/biology.mp4", "Biology", null },
                    { 15, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5115), false, 15, "/uploads/videos/painting.mp4", "Painting", null },
                    { 7, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5034), false, 7, "/uploads/videos/literature.mp4", "Literature", null },
                    { 9, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5038), false, 9, "/uploads/videos/modal-verbs.mp4", "Modal Verbs", null },
                    { 8, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5036), false, 8, "/uploads/videos/human-rights.mp4", "Human Rights", null },
                    { 6, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5033), false, 6, "/uploads/videos/football.mp4", "Football", null },
                    { 5, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5032), false, 5, "/uploads/videos/eastern-europe.mp4", "Ukraine", null },
                    { 4, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5028), false, 4, "/uploads/videos/office-suite.mp4", "Office Suite", null },
                    { 3, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5026), false, 3, "/uploads/videos/coding.mp4", "Coding", null },
                    { 2, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5022), false, 2, "/uploads/videos/man-teaching.mp4", "Teaching", null },
                    { 1, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(3293), false, 1, "/uploads/videos/modal-verbs.mp4", "Teaching", null },
                    { 10, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5041), false, 10, "/uploads/videos/russian-language.mp4", "Russian Language", null },
                    { 16, "video/mp4", new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5118), false, 16, "/uploads/videos/entrepreneurship.mp4", "Entrepreneurship", null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(9409), "Bad language in comment.", false, null, "Unacceptable behaviour" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
