using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class AgeModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "StudentsGroups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Requests",
                newName: "RequestStatus");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(20));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StudentsGroups",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "RequestStatus",
                table: "Requests",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "CourseName");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Age",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Age",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Age",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Age",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Age",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Age",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Age",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Age",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "Age",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 31);
        }
    }
}
