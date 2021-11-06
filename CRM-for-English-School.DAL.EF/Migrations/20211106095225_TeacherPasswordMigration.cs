using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class TeacherPasswordMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98cbb89-7fbe-4b0b-b7ed-11d4f0eeb9f8", true, "Fursina1990", "c9f34747-539b-4ce8-8474-139723106c57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29c98ce3-9c7f-4f43-8b0d-2f118fe64fff", true, "Fedorova1986", "b67eb5e9-8f61-4da2-b4a3-48eb52678262" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f6e136-3579-4ca5-bbe6-5376076e2d13", true, "Kalinina1992", "176b6d0f-8420-4fc3-a62f-307c77bdafab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "553a44c6-827c-4f7c-84ae-6158af47cccc", true, "Stupco1994", "ce7b9b32-a7cd-48b7-9634-e124b1427e0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb258f28-26c4-476f-bbce-57d4684a34d6", false, null, "f1b4d3e4-f98e-4463-87ac-41dbfc9c3863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eb9302a-3d28-4b42-af50-810bf7ae7d7d", false, null, "edc9709e-42df-4744-b734-d4025545d0be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca52cbdc-2729-458a-a0b1-f8239bb849e2", false, null, "534e4c91-77f5-4f42-b4f8-d3c0aca95dc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e709bc-7ca0-46b3-91da-5f53a51d4c41", false, null, "922c40c5-3ae6-486e-93b9-83b34304ed15" });
        }
    }
}
