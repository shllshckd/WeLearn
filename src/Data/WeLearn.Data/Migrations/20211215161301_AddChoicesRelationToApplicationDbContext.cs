﻿// <auto-generaed />
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddChoicesRelationToApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choice_Answers_UserAnswerId",
                table: "Choice");

            migrationBuilder.DropForeignKey(
                name: "FK_Choice_Examinations_ExaminationId",
                table: "Choice");

            migrationBuilder.DropForeignKey(
                name: "FK_Choice_Questions_QuestionId",
                table: "Choice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Choice",
                table: "Choice");

            migrationBuilder.RenameTable(
                name: "Choice",
                newName: "Choices");

            migrationBuilder.RenameIndex(
                name: "IX_Choice_UserAnswerId",
                table: "Choices",
                newName: "IX_Choices_UserAnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Choice_QuestionId",
                table: "Choices",
                newName: "IX_Choices_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Choice_IsDeleted",
                table: "Choices",
                newName: "IX_Choices_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Choice_ExaminationId",
                table: "Choices",
                newName: "IX_Choices_ExaminationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Choices",
                table: "Choices",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71b18892-3b7c-44fc-8246-136024decdba", "AQAAAAEAACcQAAAAEFCeTzB7m/J2lBMFBZ+isZ0EudktuJ+leXNyhma3Ofzd/iQKvF77OVKFM1phFY8uLA==", "94f47a6a-11af-40df-b88c-c2ccac37d651" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 334, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 16, 13, 0, 333, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Answers_UserAnswerId",
                table: "Choices",
                column: "UserAnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Examinations_ExaminationId",
                table: "Choices",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Answers_UserAnswerId",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Examinations_ExaminationId",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Choices",
                table: "Choices");

            migrationBuilder.RenameTable(
                name: "Choices",
                newName: "Choice");

            migrationBuilder.RenameIndex(
                name: "IX_Choices_UserAnswerId",
                table: "Choice",
                newName: "IX_Choice_UserAnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Choices_QuestionId",
                table: "Choice",
                newName: "IX_Choice_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Choices_IsDeleted",
                table: "Choice",
                newName: "IX_Choice_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Choices_ExaminationId",
                table: "Choice",
                newName: "IX_Choice_ExaminationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Choice",
                table: "Choice",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0057c42-4f79-4061-be5b-444a47bf64ce", "AQAAAAEAACcQAAAAENhG6ZJ74hLs56D6uX2eK8EIRd2I5lBhL2+PwtyQo8WTjTlHQ+4wEYN9YTrc7FRiGg==", "c46c1468-4aae-4447-87a2-ae6abcf09472" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 516, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 516, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 516, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 518, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 516, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 516, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 15, 6, 50, 28, 517, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.AddForeignKey(
                name: "FK_Choice_Answers_UserAnswerId",
                table: "Choice",
                column: "UserAnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Choice_Examinations_ExaminationId",
                table: "Choice",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Choice_Questions_QuestionId",
                table: "Choice",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
