using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class AddTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Age", "Degree", "FirstName", "Gender", "GraduatedFrom", "LastName", "MainSpecialization", "MiddleName" },
                values: new object[] { 1, 32, "Bachelor", "Светлана", 1, "MSLU", "Синицина", "English language history", "Викторовна" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Age", "Degree", "FirstName", "Gender", "GraduatedFrom", "LastName", "MainSpecialization", "MiddleName" },
                values: new object[] { 2, 37, "Master", "Екатерина", 1, "BSU", "Кузнецова", "Linguistics", "Степановна" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
