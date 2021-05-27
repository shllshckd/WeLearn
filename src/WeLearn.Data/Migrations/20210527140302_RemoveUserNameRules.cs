﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class RemoveUserNameRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(35)",
                oldMaxLength: 35);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9003c295-fd12-4e69-82d4-46d71f37e156", "AQAAAAEAACcQAAAAEJMvsPO0pfoNq0oasu6KndoUQT4YYvg1/RV+v0t14bFGdx//Cw4cRqhcGt5fiIsMng==", "d020e258-4e72-42f3-97b5-9fc6f85376a8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 74, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9497));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c477ee-f96a-44ed-ac40-f98df7427a71", "AQAAAAEAACcQAAAAEOTs5snk+sXydgFLUlT+lJL8syMXHMNk/jIVkog1s339mta2lHrCG6/afwbkiiSfxg==", "229fb47d-ef74-4c39-ac85-fb204f760594" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 161, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 163, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 164, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 58, 23, 162, DateTimeKind.Utc).AddTicks(9789));
        }
    }
}
