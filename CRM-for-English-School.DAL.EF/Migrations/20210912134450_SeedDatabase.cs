using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Age", "CurrentEnglishLevel", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { 5, 25, null, "SergeiKurablev@gmail.com", "Сергей", "Кураблев", "Иванович", "+375(29)987-16-48", 0 },
                    { 6, 23, null, "IrinaEgorova@gmail.com", "Ирина", "Егорова", "Владимировна", "+375(29)875-65-32", 0 },
                    { 7, 21, null, "IgorUrigoev@gmail.com", "Игорь", "Уригоев", "Александрович", "+375(29)129-45-78", 0 },
                    { 8, 27, null, "KateAltova@gmail.com", "Екатерина", "Альтова", "Станиславовна", "+375(29)852-36-14", 0 },
                    { 9, 25, null, "SvetlanaZalikova@gmail.com", "Светлана", "Заликова", "Викторовна", "+375(29)752-86-19", 0 },
                    { 10, 24, null, "DmitriKrilov@gmail.com", "Дмитрий", "Крылов", "Иванович", "+375(29)782-22-19", 0 },
                    { 11, 22, null, "AndleiBurkin@gmail.com", "Андрей", "Буркин", "Петрович", "+375(29)982-76-78", 0 },
                    { 12, 32, null, "SergeiZnakov@gmail.com", "Сергей", "Знаков", "Степанович", "+375(29)181-29-92", 0 },
                    { 13, 23, null, "StepanHoroshigin@gmail.com", "Степан", "Хорошигин", "Григорьевич", "+375(29)455-62-38", 0 },
                    { 14, 29, null, "VictoriaKlim@gmail.com", "Виктория", "Клим", "Андреевна", "+375(29)842-97-31", 0 },
                    { 15, 26, null, "FedorKurabenko@gmail.com", "Федор", "Курабенко", "Ильич", "+375(29)872-96-42", 0 },
                    { 16, 30, null, "GalinaKlimenko@gmail.com", "Галина", "Клименко", "Федоровна", "+375(29)149-75-63", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GraduatedFrom", "MainSpecialization" },
                values: new object[] { "МГЛУ", "Теоретическая и прикладная лингвистика" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GraduatedFrom", "MainSpecialization" },
                values: new object[] { "МГЛУ", "Современные иностранные языки" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Degree", "Email", "FirstName", "GraduatedFrom", "LastName", "MainSpecialization", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, 27, 0, "IrinaStupco@gmail.com", "Ирина", "МГЛУ", "Ступко", "Современные иностранные языки", "Андреевна", "+375(33)742-86-95" },
                    { 4, 31, 1, "KseniaFursina@gmail.com", "Ксения", "МГЛУ", "Фурсина", "Теоретическая и прикладная лингвистика", "Петровна", "+375(33)87565-41" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GraduatedFrom", "MainSpecialization" },
                values: new object[] { "MSLU", "Theoretical and applied linguistics" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GraduatedFrom", "MainSpecialization" },
                values: new object[] { "MSLU", "Modern foreign languages" });
        }
    }
}
