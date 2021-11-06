using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class LessonsDescMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desctiption",
                table: "Lessons",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be54d2b7-dc97-4504-91a5-628483a08b2a", "e153228c-776b-4e50-9490-f59ba21800c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16e92e75-c9c1-482f-b811-050fae80cc1c", "7e7040ef-61a2-4911-af3d-519f0c7449f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9774d7b-8c6a-4b31-b684-9ca96a204a1e", "cdd416e4-7db8-474b-8c9c-17db2b388626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "238defc9-1ab0-4a33-a75e-311184464ae6", "73ac40d6-5634-4dc1-bf56-f9adef68a7b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Lessons",
                newName: "Desctiption");

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
        }
    }
}
