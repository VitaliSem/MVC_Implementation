using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class TeacherNorNameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "980b685b-cd70-4f81-a331-3fb67c91c4c4", "KSENIAFURSINA@GMAIL.COM", "f50de42a-4f1c-496d-bd8f-d09c4ad3ef04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "e4d8624b-73a4-410e-9b16-dda408f9e6a9", "SVETLANAFEDOROVA@GMAIL.COM", "5e4d66ef-9f69-4b6f-a8cd-227cfc3a2fd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "642d6e01-899a-4984-b5ee-af3198a48c1f", "KATEKALININA@GMAIL.COM", "7fd5a340-fff0-442a-9b67-fec3acf2ce21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "60de6ca1-744d-46b1-863e-e989dc96c7e2", "IRINASTUPCO@GMAIL.COM", "90a0fcf4-1e8a-4600-89fa-262683d2f609" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "ae3d63c9-f87a-4e39-84e8-9a0a3313a051", null, "982c2b8c-93bc-4f90-8394-6d11482c8a33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "1458b449-5323-478a-ae67-7a134a8cad5b", null, "5e2d5cef-ab3d-4505-962b-b721489c1802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "9bf335b0-b8ed-44f5-af0d-e639096df43a", null, "e8469997-2203-4ea4-aeae-9d489fc0d626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "e0c58628-671c-4331-8413-29ddef907ac2", null, "1812118e-5b0b-47cf-a8f7-9716afd93920" });
        }
    }
}
