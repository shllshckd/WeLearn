﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class DisableDirectUserMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivateMessage");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", 0, "9ddab780-5a99-4523-9f36-8a1553611421", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "default@gmail.com", false, false, false, null, null, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAENRTS8YRkGzzdKUu0ff9v6cJZN/BpYnAaXHC1uxotLVPT99Pf1PBKKz42Fp5ij3mnA==", null, false, "2e626c0c-ce3e-42af-abe5-0c32372e82f8", false, "Username" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "d91316c6-8823-4614-a3c5-6228f06c746a", new DateTime(2021, 12, 4, 3, 4, 27, 846, DateTimeKind.Utc).AddTicks(3520) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a");

            migrationBuilder.CreateTable(
                name: "PrivateMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ReceiverId = table.Column<string>(type: "text", nullable: true),
                    SenderId = table.Column<string>(type: "text", nullable: true),
                    Text = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateMessage_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrivateMessage_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "0c0cd420-baad-4e0b-a3cc-7e0e2730fdac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "default@gmail.com", false, false, false, null, null, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAEK13/BbamUPJwtep9JgTHQw1yLOUaGKFg0gxuCPoWwy83BYIAnSXFMcocM8eNaoq2w==", null, false, "ea1a753c-076c-4c6a-867b-68001c7b3194", false, "Username" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedOn" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessage_IsDeleted",
                table: "PrivateMessage",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessage_ReceiverId",
                table: "PrivateMessage",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessage_SenderId",
                table: "PrivateMessage",
                column: "SenderId");
        }
    }
}
