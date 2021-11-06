using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class LessonsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desctiption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_StudentsGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "StudentsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbd3076d-79a9-4a13-b91c-e4b063180cca", "e9bdc271-d9aa-4d80-ae8a-7a8c120c043f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "697beca8-49c1-4c55-b419-738967319fe7", "4b821a6f-9504-4330-b77a-4d2ffe0044e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de28d7ef-bae0-4893-b3e1-de4be40c347b", "0fbc08e8-ab24-4fca-be66-2bab1912b34a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c75ee89b-72fd-486e-8b78-f65599d6402f", "2aefd92d-35ba-4cca-b570-2a020ce30c8c" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                table: "Lessons",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a98cbb89-7fbe-4b0b-b7ed-11d4f0eeb9f8", "c9f34747-539b-4ce8-8474-139723106c57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29c98ce3-9c7f-4f43-8b0d-2f118fe64fff", "b67eb5e9-8f61-4da2-b4a3-48eb52678262" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27f6e136-3579-4ca5-bbe6-5376076e2d13", "176b6d0f-8420-4fc3-a62f-307c77bdafab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "553a44c6-827c-4f7c-84ae-6158af47cccc", "ce7b9b32-a7cd-48b7-9634-e124b1427e0b" });
        }
    }
}
