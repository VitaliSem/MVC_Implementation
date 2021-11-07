using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18fedd72-d3e2-4033-9744-877b60a5a2ff", 0, "70a7c2dd-e419-4b6c-9c39-4bdee29447a0", "SvetlanaFedorova@gmail.com", true, false, null, "SVETLANAFEDOROVA@GMAIL.COM", "SVETLANAFEDOROVA@GMAIL.COM", "Fedorova1986", null, false, "d193d0dd-c112-4489-b02f-67090f8ab83e", false, "SvetlanaFedorova@gmail.com" },
                    { "2aa85a78-dba9-49d8-8215-89f793f1fd74", 0, "9f132e21-245d-4190-a656-83bf06f28591", "KateKalinina@gmail.com", true, false, null, "KATEKALININA@GMAIL.COM", "KATEKALININA@GMAIL.COM", "Kalinina1992", null, false, "94d98755-d350-41c5-b07e-d0100ba760ee", false, "KateKalinina@gmail.com" },
                    { "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9", 0, "061168d3-39a1-484d-baaf-43d835e9c47a", "IrinaStupco@gmail.com", true, false, null, "IRINASTUPCO@GMAIL.COM", "IRINASTUPCO@GMAIL.COM", "Stupco1994", null, false, "7e90d362-62ed-4e57-8cf4-ed2917505aef", false, "IrinaStupco@gmail.com" },
                    { "008120a7-6d9c-4f2e-83aa-52764cc6e3b7", 0, "e8f01f31-5a02-43f4-87bf-8ec0430f1e1f", "KseniaFursina@gmail.com", true, false, null, "KSENIAFURSINA@GMAIL.COM", "KSENIAFURSINA@GMAIL.COM", "Fursina1990", null, false, "ac7a8f0c-6363-4f8f-b479-ae9e806f8f6f", false, "KseniaFursina@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CurrentEnglishLevel", "Email", "FirstName", "GroupId", "LastName", "MiddleName", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KonstantinKvaskov@gmail.com", "Константин", null, "Квасков", "Игоревич", "+375(29)616-94-87", 0 },
                    { 2, new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "OlgaLabudco@gmail.com", "Ольга", null, "Лабудько", "Петрович", "+375(33)822-74-13", 0 },
                    { 3, new DateTime(1997, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KateSoroka@gmail.com", "Екатерина", null, "Сорока", "Степановна", "+375(33)555-66-77", 0 },
                    { 4, new DateTime(1993, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "IvanLikov@gmail.com", "Иван", null, "Лыков", "Федорович", "+375(29)996-74-14", 0 },
                    { 5, new DateTime(1998, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "PolyGolubeva@gmail.com", "Полина", null, "Голубева", "Алексеевна", "+375(29)622-74-74", 0 },
                    { 6, new DateTime(1994, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "SvetoslavOgorodnik@gmail.com", "Светослав", null, "Огородник", "Дмитриевич", "+375(29)743-96-13", 0 },
                    { 7, new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KristinaKarayl@gmail.com", "Кристина", null, "Караул", "Федоровна", "+375(29)120-19-84", 0 },
                    { 8, new DateTime(1996, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "EugeniaAlbegova@gmail.com", "Евгения", null, "Альбегова", "Петровна", "+375(29)545-75-75", 0 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BirthDate", "Degree", "Email", "FirstName", "GraduatedFrom", "HasPhoto", "LastName", "MainSpecialization", "MiddleName", "PhoneNumber", "Photo", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(1986, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "SvetlanaFedorova@gmail.com", "Светлана", "МГЛУ", false, "Федорова", "Теоретическая и прикладная лингвистика", "Георгиевна", "+375(29)654-45-67", null, new Guid("18fedd72-d3e2-4033-9744-877b60a5a2ff"), null },
                    { 2, new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "KateKalinina@gmail.com", "Екатерина", "МГЛУ", false, "Калинина", "Современные иностранные языки", "Викторовна", "+375(33)151-16-19", null, new Guid("2aa85a78-dba9-49d8-8215-89f793f1fd74"), null },
                    { 3, new DateTime(1994, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "IrinaStupco@gmail.com", "Ирина", "МГЛУ", false, "Ступко", "Современные иностранные языки", "Андреевна", "+375(33)742-86-95", null, new Guid("465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9"), null },
                    { 4, new DateTime(1990, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KseniaFursina@gmail.com", "Ксения", "МГЛУ", false, "Фурсина", "Теоретическая и прикладная лингвистика", "Петровна", "+375(33)87565-41", null, new Guid("008120a7-6d9c-4f2e-83aa-52764cc6e3b7"), null }
                });

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
    }
}
