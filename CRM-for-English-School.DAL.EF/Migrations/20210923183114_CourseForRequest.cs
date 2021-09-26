using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class CourseForRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CourseId",
                table: "Requests",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Courses_CourseId",
                table: "Requests",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Courses_CourseId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_CourseId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Requests");
        }
    }
}
