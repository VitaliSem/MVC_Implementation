using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class TeacherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb258f28-26c4-476f-bbce-57d4684a34d6", "f1b4d3e4-f98e-4463-87ac-41dbfc9c3863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eb9302a-3d28-4b42-af50-810bf7ae7d7d", "edc9709e-42df-4744-b734-d4025545d0be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca52cbdc-2729-458a-a0b1-f8239bb849e2", "534e4c91-77f5-4f42-b4f8-d3c0aca95dc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5e709bc-7ca0-46b3-91da-5f53a51d4c41", "922c40c5-3ae6-486e-93b9-83b34304ed15" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "980b685b-cd70-4f81-a331-3fb67c91c4c4", "f50de42a-4f1c-496d-bd8f-d09c4ad3ef04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4d8624b-73a4-410e-9b16-dda408f9e6a9", "5e4d66ef-9f69-4b6f-a8cd-227cfc3a2fd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "642d6e01-899a-4984-b5ee-af3198a48c1f", "7fd5a340-fff0-442a-9b67-fec3acf2ce21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60de6ca1-744d-46b1-863e-e989dc96c7e2", "90a0fcf4-1e8a-4600-89fa-262683d2f609" });
        }
    }
}
