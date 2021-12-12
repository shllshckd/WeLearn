﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddSeededChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Quizzes",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a174a642-94bb-4182-aca5-bd18caf56658", "AQAAAAEAACcQAAAAEE+Y+nlQL501ZcgY1jAv6AVRtmAYzBJT6QnH3wJiYtnuIRyGNi6+SGlz079rWmoA1A==", "ebaec100-c046-4ba9-899e-5e6e22258f13" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(6843), null, "Main" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.InsertData(
                table: "ChatApplicationUsers",
                columns: new[] { "ApplicationUserId", "ChatId" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChatApplicationUsers",
                keyColumns: new[] { "ApplicationUserId", "ChatId" },
                keyValues: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", 1 });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Quizzes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdfe31d-852f-4d57-b05e-0df391490870", "AQAAAAEAACcQAAAAEM/CaOHh2JM82KTILz4RBscE3kKhiIaUL/MHi5xrDuRu8FiQHkZwKXVwGCIh3NuHpA==", "b041af42-09e5-4a0d-a8db-23de4bb88e23" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4046));
        }
    }
}
