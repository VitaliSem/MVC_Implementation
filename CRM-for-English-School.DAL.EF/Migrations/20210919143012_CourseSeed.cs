using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class CourseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Анлийский для взрослых - PI_1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Английский для бизнеса - B-I_1");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EnglishLevel", "ExpectedStartDate", "Name" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - UI_1" },
                    { 4, 2, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - I_1" },
                    { 5, 0, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - E_1" },
                    { 6, 0, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для бизнеса - B-E_1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "English for Adults");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "English for Business");
        }
    }
}
