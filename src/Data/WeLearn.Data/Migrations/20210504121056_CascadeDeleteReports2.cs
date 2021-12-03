﻿using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class CascadeDeleteReports2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "DateResolved",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46c8292e-a8fe-49cf-9264-bb063d230d78", "AQAAAAEAACcQAAAAEJf1OkphpjMYXHCjB3ea5bpRNuEgtf8Bkx6lUpGqJR+V5dIgBJaSaxZduOhFYxwJ+w==", "68a715ed-6666-43c0-b359-b8e3962882fe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateResolved",
                table: "Reports",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsResolved",
                table: "Reports",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55ba5621-b36c-48d3-ac5c-5678a1cef4f2", "AQAAAAEAACcQAAAAEAlhE/KFiyW8SFq8ehBjXPgMoirD1YvPovAyL8TQqLSVkLgC/aikJ/6Kwc8gmolzjg==", "04aabe33-f1a1-48f3-96fd-eee878e682a7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 337, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 337, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 337, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 339, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 337, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 8, 48, 338, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
