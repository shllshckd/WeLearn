﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeFluentApiSettingsForVideoAndMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons");

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
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
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
                keyValue: 5);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Videos_LessonId",
                table: "Videos",
                column: "LessonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_LessonId",
                table: "Materials",
                column: "LessonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_LessonId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Materials_LessonId",
                table: "Materials");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "81c4001f-552c-4aaa-92e7-243cb0c354b5", "default@gmail.com", false, false, null, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAEEQ1FsyBqfIV0dMvv0Rh7wqh/H2du9XvbmEiX5c0iI37ND72Hy5xvZQz9Ch5b/+kfA==", null, false, "21427493-1ae5-40e3-a35e-6fb93d674751", false, "Username" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1308), false, "Others" },
                    { 16, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1307), false, "Technologies and Entrepreneurship" },
                    { 15, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1305), false, "Art" },
                    { 14, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1304), false, "Music" },
                    { 13, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1303), false, "Chemistry" },
                    { 11, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1300), false, "History" },
                    { 10, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1299), false, "Russian Language" },
                    { 9, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1298), false, "English Language" },
                    { 12, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1302), false, "Biology" },
                    { 7, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1295), false, "Literature" },
                    { 6, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1294), false, "Physical Education and Sport" },
                    { 5, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1292), false, "Geography" },
                    { 4, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1291), false, "IT" },
                    { 3, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1290), false, "Informatics" },
                    { 2, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1287), false, "Mathematics" },
                    { 1, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(381), false, "Bulgarian Language" },
                    { 8, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1297), false, "Civic Education" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(350), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Russian Language", null },
                    { 16, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(357), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Entrepreneurship", null },
                    { 15, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(356), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Painting", null },
                    { 14, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(355), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Music", null },
                    { 13, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(353), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Chemistry", null },
                    { 12, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(352), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Biology", null },
                    { 11, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(351), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "History", null },
                    { 9, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(349), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Modal Verbs", null },
                    { 7, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(346), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Literature", null },
                    { 6, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(345), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Football", null },
                    { 5, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(342), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Ukraine", null },
                    { 4, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(341), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Office Suite", null },
                    { 3, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(340), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Coding", null },
                    { 2, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(336), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 1, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(9034), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 8, new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(347), false, 0, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Human Rights", null }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "ContentType", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 15, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3831), false, 0, "/uploads/videos/painting.mp4", "Painting", null },
                    { 14, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3829), false, 0, "/uploads/videos/music.mp4", "Music", null },
                    { 13, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3828), false, 0, "/uploads/videos/chemistry.mp4", "Chemistry", null },
                    { 12, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3826), false, 0, "/uploads/videos/biology.mp4", "Biology", null },
                    { 11, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3721), false, 0, "/uploads/videos/history.mp4", "History", null },
                    { 10, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3720), false, 0, "/uploads/videos/russian-language.mp4", "Russian Language", null },
                    { 9, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3718), false, 0, "/uploads/videos/modal-verbs.mp4", "Modal Verbs", null },
                    { 5, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3712), false, 0, "/uploads/videos/eastern-europe.mp4", "Ukraine", null },
                    { 7, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3716), false, 0, "/uploads/videos/literature.mp4", "Literature", null },
                    { 6, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3714), false, 0, "/uploads/videos/football.mp4", "Football", null },
                    { 4, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3711), false, 0, "/uploads/videos/office-suite.mp4", "Office Suite", null },
                    { 3, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3709), false, 0, "/uploads/videos/coding.mp4", "Coding", null },
                    { 2, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3706), false, 0, "/uploads/videos/man-teaching.mp4", "Teaching", null },
                    { 1, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1977), false, 0, "/uploads/videos/modal-verbs.mp4", "Teaching", null },
                    { 8, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3717), false, 0, "/uploads/videos/human-rights.mp4", "Human Rights", null },
                    { 16, "video/mp4", new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3832), false, 0, "/uploads/videos/entrepreneurship.mp4", "Entrepreneurship", null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "Description", "Grade", "IsApproved", "IsDeleted", "MaterialId", "Name", "VideoId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(7059), "A lecture about pronouns and when to use them.", 1, true, false, 1, "Pronouns, types", 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8351), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 2, true, false, 2, "Prime numbers", 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8355), "About the C# language and the .NET development Platform. First steps.", 3, true, false, 3, "Developing with C#", 3 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8357), "Data analysis.", 4, true, false, 4, "Excel", 4 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8358), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 5, true, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8360), "Kicking a ball on the field.", 6, true, false, 6, "Football", 6 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8362), "A peek into Shakespere's art.", 7, true, false, 7, "William Shakespere's 106 sonnet", 7 },
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8364), "A lecture about rights of the people.", 8, true, false, 8, "Human rights", 8 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8365), "We use modals to show if we believe something is certain, possible or impossible.", 9, true, false, 9, "Modal verbs", 9 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8367), "A lecture about the verbs of motion and when to use them.", 10, true, false, 10, "Verbs of motion", 10 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8368), "A brief peek into our ancestors' life.", 11, true, false, 11, "Peek in the past", 11 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8370), "A lesson about the different types of cells and their differences.", 12, true, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8372), "A lesson about acids, they effects on the environtment and usage cases.", 0, true, false, 13, "Acids, Bases and pH", 13 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8374), "Genres, instruments and notation.", 5, true, false, 14, "Popular music", 14 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8375), "Pigments, brushes, bases, matrices.", 1, true, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8377), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 2, true, false, 16, "Entrepreneurship", 16 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "IsDeleted", "LessonId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "I like it!", new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(3700), false, 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "The teacher is awesome.", new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(5582), false, 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "This is just great.", new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(5587), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(6745), "Bad language in lesson's title.", false, 5, "The language used in title" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(8540), "Bad language in comment.", false, null, "Unacceptable behaviour" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons",
                column: "VideoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
