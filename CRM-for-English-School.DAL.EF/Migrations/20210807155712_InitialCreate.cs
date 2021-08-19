using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentEnglishLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentsGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentsGroups_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "CurrentEnglishLevel", "FirstName", "Gender", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, 23, "Elementary", "Иван", 0, "Иванов", "Иванович" },
                    { 2, 28, "Pre-Intermediate", "Петр", 0, "Петров", "Петрович" },
                    { 3, 24, "Intermediate", "Ольга", 1, "Синичкина", "Дмитриевна" },
                    { 4, 25, "Intermediate", "Виктор", 0, "Васнецов", "Борисович" },
                    { 5, 23, "Elementary", "Дарья", 1, "Прокофьева", "Петровна" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsGroups_TeacherId",
                table: "StudentsGroups",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentsGroups");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
