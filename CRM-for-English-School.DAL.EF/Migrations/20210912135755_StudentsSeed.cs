using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class StudentsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CurrentEnglishLevel", "Email", "FirstName", "GroupId", "GroupdId", "LastName", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 23, 2, "KonstantinKvaskov@gmail.com", "Константин", null, 0, "Квасков", "Игоревич", "+375(29)616-94-87" },
                    { 2, 21, 2, "OlgaLabudco@gmail.com", "Ольга", null, 0, "Лабудько", "Петрович", "+375(33)822-74-13" },
                    { 3, 24, 2, "KateSoroka@gmail.com", "Екатерина", null, 0, "Сорока", "Степановна", "+375(33)555-66-77" },
                    { 4, 28, 2, "IvanLikov@gmail.com", "Иван", null, 0, "Лыков", "Федорович", "+375(29)996-74-14" },
                    { 5, 23, 2, "PolyGolubeva@gmail.com", "Полина", null, 0, "Голубева", "Алексеевна", "+375(29)622-74-74" },
                    { 6, 27, 2, "SvetoslavOgorodnik@gmail.com", "Светослав", null, 0, "Огородник", "Дмитриевич", "+375(29)743-96-13" },
                    { 7, 28, 2, "KristinaKarayl@gmail.com", "Кристина", null, 0, "Караул", "Федоровна", "+375(29)120-19-84" },
                    { 8, 25, 2, "EugeniaAlbegova@gmail.com", "Евгения", null, 0, "Альбегова", "Петровна", "+375(29)545-75-75" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
