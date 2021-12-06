﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ConnectLikesWithLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Likes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Likes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41bd33f1-26be-470e-8759-931fe279288a", "AQAAAAEAACcQAAAAEF4LDvLaCZ0TMZwSaqLC/5AWI8kOgG9MqUb61HHtvLNsSE//mcqr4PUfxpGlWmz51Q==", "f0714a56-7a58-4dc9-afe0-175e02bbdd2f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.CreateIndex(
                name: "IX_Likes_IsDeleted",
                table: "Likes",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_IsDeleted",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Likes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb1de8d2-e3e5-4dcb-bbad-c94cab82a83d", "AQAAAAEAACcQAAAAEPG8Gm2hA2ZKI4D2nFPw87UFpNcBWqvXAjoOH51Vvlls30x2hHRHJZgrY91i7TeoOA==", "ef080e9c-c6c2-4286-a4e0-0b4984306dad" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 90, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 21, 58, 2, 89, DateTimeKind.Utc).AddTicks(9888));
        }
    }
}
