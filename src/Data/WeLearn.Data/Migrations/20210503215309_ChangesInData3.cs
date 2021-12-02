﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bb1c4d6-0f1c-48e5-8738-986d1fbb0bdf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "c25adee0-80c0-4de0-8aa6-16f213a71b71", "58883fe4-8c5c-43f5-9408-0218386782fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43dea297-ff8f-4290-a9e9-f1ad83dda5f4", "AQAAAAEAACcQAAAAEHfY1sbdU0oej10AeEJHVgx9LDTww6uBdnXcWCT4TqNpZEvxXnkePq5VmItHJPTk9w==", "1b0b42a8-e075-43e2-8a40-214684e09db3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 504, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 504, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 504, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 506, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 504, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 53, 8, 505, DateTimeKind.Utc).AddTicks(6801));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25adee0-80c0-4de0-8aa6-16f213a71b71");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "8bb1c4d6-0f1c-48e5-8738-986d1fbb0bdf", "4e5320fc-4c58-4e7c-9b19-edee79af6c1b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d18595-cda9-4a32-87d2-ee0e25350bd3", "AQAAAAEAACcQAAAAEGoGIQokSQPf5CQEuNYVudzbXEOnEZ+2fVvjaEPBt++1LqTsUeYKJtwSk5CxB51/1g==", "316f7d80-3ecd-4e82-9a70-58f08b8d8c0f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 997, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(5));
        }
    }
}