﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class AddPrivateMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivateMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserPrivateMessage",
                columns: table => new
                {
                    ParticipantsId = table.Column<string>(type: "text", nullable: false),
                    PrivateMessagesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPrivateMessage", x => new { x.ParticipantsId, x.PrivateMessagesId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrivateMessage_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrivateMessage_PrivateMessages_PrivateMessag~",
                        column: x => x.PrivateMessagesId,
                        principalTable: "PrivateMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cca01f76-31a1-4067-b43e-b841142441a6", "AQAAAAEAACcQAAAAECFTcI8E6d4cxtQF56U+BbBVAdgCl724HRgjqku0LYePi/DtBmsv01QrqLjDgcTA5g==", "58f6503a-2737-49a6-96d9-7ee050fbad8e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPrivateMessage_PrivateMessagesId",
                table: "ApplicationUserPrivateMessage",
                column: "PrivateMessagesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPrivateMessage");

            migrationBuilder.DropTable(
                name: "PrivateMessages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af5d4bc3-bcbb-4ede-8e2c-1af23f331d5a", "AQAAAAEAACcQAAAAEIjCCrorvCwi4A9MOAX6f4C2WRiIN5Cdd88d6Cbjt7Qjra+HuKAfefVpG7NnElYljg==", "0d677ee9-77b9-4e15-8e6d-73ed524ae9de" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8316));
        }
    }
}