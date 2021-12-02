﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dcf3a7b-40ab-4999-987c-70009ae60e89", "AQAAAAEAACcQAAAAECLoK5b3ACHEmUpfNnoFxFFEfxFns0wlkgS4bPE2tmBUjvRnQAVxyhlHP8sknVPoBA==", "34dba80e-997e-410c-960b-fa77a91d6df9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 779, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2775), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3993), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3996), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3998), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3999), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4001), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4002), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4003), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4004), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4006), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4007), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4008), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4010), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4011), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4012), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4013), "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8518));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0bc5f7e-aab2-47df-b89b-f6ecfa4d2626", "AQAAAAEAACcQAAAAELvBQ0wJw5Vy2RLZcsC+Lkv4VcOgN5iDTekbET1AQjZL77Yln/SKyPgxQvNVSEXeuw==", "2a594a73-47ee-41b1-9462-422cfaeed6d3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(9331), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(839), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(843), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(845), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(846), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(847), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(848), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(849), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(851), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(852), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(853), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(854), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(855), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(857), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(858), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(859), "..." });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4087));
        }
    }
}