using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class TeacherRolesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18fedd72-d3e2-4033-9744-877b60a5a2ff", 0, "1458b449-5323-478a-ae67-7a134a8cad5b", "SvetlanaFedorova@gmail.com", false, false, null, "SVETLANAFEDOROVA@GMAIL.COM", null, null, null, false, "5e2d5cef-ab3d-4505-962b-b721489c1802", false, "SvetlanaFedorova@gmail.com" },
                    { "2aa85a78-dba9-49d8-8215-89f793f1fd74", 0, "9bf335b0-b8ed-44f5-af0d-e639096df43a", "KateKalinina@gmail.com", false, false, null, "KATEKALININA@GMAIL.COM", null, null, null, false, "e8469997-2203-4ea4-aeae-9d489fc0d626", false, "KateKalinina@gmail.com" },
                    { "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9", 0, "e0c58628-671c-4331-8413-29ddef907ac2", "IrinaStupco@gmail.com", false, false, null, "IRINASTUPCO@GMAIL.COM", null, null, null, false, "1812118e-5b0b-47cf-a8f7-9716afd93920", false, "IrinaStupco@gmail.com" },
                    { "008120a7-6d9c-4f2e-83aa-52764cc6e3b7", 0, "ae3d63c9-f87a-4e39-84e8-9a0a3313a051", "KseniaFursina@gmail.com", false, false, null, "KSENIAFURSINA@GMAIL.COM", null, null, null, false, "982c2b8c-93bc-4f90-8394-6d11482c8a33", false, "KseniaFursina@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("18fedd72-d3e2-4033-9744-877b60a5a2ff"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("2aa85a78-dba9-49d8-8215-89f793f1fd74"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("008120a7-6d9c-4f2e-83aa-52764cc6e3b7"));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "18fedd72-d3e2-4033-9744-877b60a5a2ff" },
                    { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "2aa85a78-dba9-49d8-8215-89f793f1fd74" },
                    { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9" },
                    { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "008120a7-6d9c-4f2e-83aa-52764cc6e3b7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "008120a7-6d9c-4f2e-83aa-52764cc6e3b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "18fedd72-d3e2-4033-9744-877b60a5a2ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "2aa85a78-dba9-49d8-8215-89f793f1fd74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc51b262-0dbf-442d-a121-3fcb5f25d9fb", "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "008120a7-6d9c-4f2e-83aa-52764cc6e3b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18fedd72-d3e2-4033-9744-877b60a5a2ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa85a78-dba9-49d8-8215-89f793f1fd74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
