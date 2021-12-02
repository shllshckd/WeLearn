﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeVideosSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f0be93-e6d9-4371-b4a9-99c8c46714ff", "AQAAAAEAACcQAAAAELHT+yjD0tf7H6Sc86eptqlZRaZkviU0GECgTHmM2vyc5rFXXw0KVX0QJoo/FoGvZw==", "23c00b92-3660-4857-acef-7675a2d40096" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 210, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 20, 30, 14, 208, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(1632), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622056204/welearn-asp-net-core-app/videos/seed/teacher-presenting.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3787), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053205/welearn-asp-net-core-app/videos/seed/man-teaching_miueor.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3791), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053215/welearn-asp-net-core-app/videos/seed/coding_bbc9sv.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3793), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053172/welearn-asp-net-core-app/videos/seed/office-suite_lugjnz.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3794), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053238/welearn-asp-net-core-app/videos/seed/eastern-europe_a7ljx0.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3795), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053255/welearn-asp-net-core-app/videos/seed/football_basmoc.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3797), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053256/welearn-asp-net-core-app/videos/seed/literature_u1mriv.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3799), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053261/welearn-asp-net-core-app/videos/seed/human-rights_vbojip.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3800), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053183/welearn-asp-net-core-app/videos/seed/modal-verbs_jjnya3.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3802), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053192/welearn-asp-net-core-app/videos/seed/russian-language_uaydhx.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3871), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053246/welearn-asp-net-core-app/videos/seed/history_sll9r9.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3874), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053200/welearn-asp-net-core-app/videos/seed/biology_veyt5f.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3875), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053225/welearn-asp-net-core-app/videos/seed/chemistry_zpdwl9.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3876), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053175/welearn-asp-net-core-app/videos/seed/music_x6vt4y.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3877), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053181/welearn-asp-net-core-app/videos/seed/painting_glxyu0.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 26, 20, 30, 14, 209, DateTimeKind.Utc).AddTicks(3879), "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053249/welearn-asp-net-core-app/videos/seed/entrepreneurship_ulreso.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "206afdd1-c40a-48fc-80ab-244ec0453c23", "AQAAAAEAACcQAAAAEAqSH6bqN29koBmFOc0puAPii4EIQqqBw1Gug6wI2j9KY5MumQq6fuUuoOvQRqg0eQ==", "d38de91e-7d0b-47dd-880f-54b86942f2b8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 745, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 8, 58, 27, 743, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(3293), "/uploads/videos/modal-verbs.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5022), "/uploads/videos/man-teaching.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5026), "/uploads/videos/coding.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5028), "/uploads/videos/office-suite.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5032), "/uploads/videos/eastern-europe.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5033), "/uploads/videos/football.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5034), "/uploads/videos/literature.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5036), "/uploads/videos/human-rights.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5038), "/uploads/videos/modal-verbs.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5041), "/uploads/videos/russian-language.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5104), "/uploads/videos/history.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5110), "/uploads/videos/biology.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5111), "/uploads/videos/chemistry.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5113), "/uploads/videos/music.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5115), "/uploads/videos/painting.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 58, 27, 744, DateTimeKind.Utc).AddTicks(5118), "/uploads/videos/entrepreneurship.mp4" });
        }
    }
}