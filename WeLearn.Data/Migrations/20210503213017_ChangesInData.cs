﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa81e10-b03f-4061-b162-2c823fa8a29a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "4ec701d9-7f54-4479-a9be-ecd4f4ff8cdf", "519c380d-8844-4451-a14d-44caf54ee694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe5673c-0b92-4e9e-8d1f-2f6f4be159d3", "default@gmail.com", false, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAEEJ6pluUMGsYKxxh9+DpSsPJt1zP57TfCeFxLPBPme7Y79JdNnuINwUW8jToQtdYxQ==", "799daa61-4e52-4f4e-a019-bec04816e073" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2397));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ec701d9-7f54-4479-a9be-ecd4f4ff8cdf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "6aa81e10-b03f-4061-b162-2c823fa8a29a", "de45acb0-204e-4ae3-9e52-b84283d60c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c56a6ab2-f48c-42b3-b1d2-30b4b65f0fe4", "user@gmail.com", true, null, null, "AQAAAAEAACcQAAAAEMslx2XoZvuR8S9agDIqXnmxELZfua1EOVTBMAmfOh8b9j34x2DECHQkrrpwd1+IRw==", "cece20fc-49a8-441e-aaa9-9133bf628221" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3421));
        }
    }
}
