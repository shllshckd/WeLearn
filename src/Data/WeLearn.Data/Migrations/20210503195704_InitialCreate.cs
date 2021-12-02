﻿using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8346fdda-bbd2-4905-bcf3-e013c9c77265");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15e3e7dc-2707-419f-b113-2a383f0d50f7", "6a8d3eda-637c-404e-abe2-48790b4d7c88", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b241348-966f-43eb-8eff-5629a6e0502a", "AQAAAAEAACcQAAAAEKuosvi2EHVUaK+FGlzX/iCatJNa0UTEfWXnmEOEZ7OppXeptitW6fyRJGhb+LIWIQ==", "39fc3e65-bcb9-416f-8972-972cd81a1eff" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 540, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 538, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 57, 3, 539, DateTimeKind.Utc).AddTicks(4590));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e3e7dc-2707-419f-b113-2a383f0d50f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8346fdda-bbd2-4905-bcf3-e013c9c77265", "1407719d-9e39-44b0-9690-b9248fabdd23", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a88f5b4-132e-473e-8c0e-451868042ac0", "AQAAAAEAACcQAAAAEKaKGPboN7L3cRmBuQjFtx1J9I9o6/PIRB6URjxUY8hpnl0ak9OnBkUwzCNoTV6OEQ==", "977b1308-3c3e-4dc8-bf80-7803ce4576ab" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(522));
        }
    }
}