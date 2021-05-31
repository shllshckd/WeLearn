﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddUserNameRuleAgainInApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(35)",
                oldMaxLength: 35,
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(35)",
                oldMaxLength: 35);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0019f772-eac5-40df-b8a2-7fd8dd02ef80", "AQAAAAEAACcQAAAAEEqHA4dTVoa8ofKNMImCUOazm7PK/pxG4OoRdzutyOIBMbVJ4sSe/7iliZIr2SdudA==", "31b8efa6-87bb-4182-8f85-abe219113d6f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 302, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2248));
        }
    }
}