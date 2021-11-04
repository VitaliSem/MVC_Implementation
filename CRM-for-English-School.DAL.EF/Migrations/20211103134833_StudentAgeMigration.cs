﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class StudentAgeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Students",
                type: "int",
                nullable: true,
                computedColumnSql: "DATEDIFF(YEAR,BirthDate,GETDATE())",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComputedColumnSql: "DATEDIFF(YEAR,BirthDate,GETDATE())");
        }
    }
}