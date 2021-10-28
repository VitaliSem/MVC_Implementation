using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishLevel = table.Column<int>(type: "int", nullable: false),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    CurrentEnglishLevel = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true, computedColumnSql: "DATEDIFF(YEAR,BirthDate,GETDATE())"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishLevel = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsGroups_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentEnglishLevel = table.Column<int>(type: "int", nullable: false),
                    GroupdId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_StudentsGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "StudentsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EnglishLevel", "ExpectedStartDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Анлийский для взрослых - PI_1", 980.0 },
                    { 2, 2, new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для бизнеса - B-I_1", 1180.0 },
                    { 3, 3, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - UI_1", 1180.0 },
                    { 4, 2, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - I_2", 1030.0 },
                    { 5, 2, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для взрослых - I_1", 1030.0 },
                    { 6, 1, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский для бизнеса - B-PI_1", 1030.0 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "BirthDate", "CurrentEnglishLevel", "Email", "FirstName", "GroupId", "GroupdId", "LastName", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 8, null, new DateTime(1996, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "EugeniaAlbegova@gmail.com", "Евгения", null, 0, "Альбегова", "Петровна", "+375(29)545-75-75" },
                    { 7, null, new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KristinaKarayl@gmail.com", "Кристина", null, 0, "Караул", "Федоровна", "+375(29)120-19-84" },
                    { 6, null, new DateTime(1994, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "SvetoslavOgorodnik@gmail.com", "Светослав", null, 0, "Огородник", "Дмитриевич", "+375(29)743-96-13" },
                    { 5, null, new DateTime(1998, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "PolyGolubeva@gmail.com", "Полина", null, 0, "Голубева", "Алексеевна", "+375(29)622-74-74" },
                    { 3, null, new DateTime(1997, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KateSoroka@gmail.com", "Екатерина", null, 0, "Сорока", "Степановна", "+375(33)555-66-77" },
                    { 2, null, new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "OlgaLabudco@gmail.com", "Ольга", null, 0, "Лабудько", "Петрович", "+375(33)822-74-13" },
                    { 1, null, new DateTime(1998, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KonstantinKvaskov@gmail.com", "Константин", null, 0, "Квасков", "Игоревич", "+375(29)616-94-87" },
                    { 4, null, new DateTime(1993, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "IvanLikov@gmail.com", "Иван", null, 0, "Лыков", "Федорович", "+375(29)996-74-14" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "BirthDate", "Degree", "Email", "FirstName", "GraduatedFrom", "LastName", "MainSpecialization", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, null, new DateTime(1994, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "IrinaStupco@gmail.com", "Ирина", "МГЛУ", "Ступко", "Современные иностранные языки", "Андреевна", "+375(33)742-86-95" },
                    { 1, null, new DateTime(1986, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "SvetlanaFedorova@gmail.com", "Светлана", "МГЛУ", "Федорова", "Теоретическая и прикладная лингвистика", "Георгиевна", "+375(29)654-45-67" },
                    { 2, null, new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "KateKalinina@gmail.com", "Екатерина", "МГЛУ", "Калинина", "Современные иностранные языки", "Викторовна", "+375(33)151-16-19" },
                    { 4, null, new DateTime(1990, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KseniaFursina@gmail.com", "Ксения", "МГЛУ", "Фурсина", "Теоретическая и прикладная лингвистика", "Петровна", "+375(33)87565-41" }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "BirthDate", "CourseId", "CurrentEnglishLevel", "DateOfRequest", "Email", "FirstName", "LastName", "MiddleName", "PhoneNumber", "RequestStatus" },
                values: new object[,]
                {
                    { 2, new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2021, 8, 12, 20, 11, 6, 0, DateTimeKind.Unspecified), "PetrPetrov@gmail.com", "Петр", "Петров", "Петрович", "+375(33)454-44-55", 1 },
                    { 15, new DateTime(1995, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, new DateTime(2021, 8, 17, 19, 46, 32, 0, DateTimeKind.Unspecified), "FedorKurabenko@gmail.com", "Федор", "Курабенко", "Ильич", "+375(29)872-96-42", 1 },
                    { 9, new DateTime(1996, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, new DateTime(2021, 8, 15, 22, 9, 40, 0, DateTimeKind.Unspecified), "SvetlanaZalikova@gmail.com", "Светлана", "Заликова", "Викторовна", "+375(29)752-86-19", 1 },
                    { 28, new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, new DateTime(2021, 9, 6, 18, 40, 31, 0, DateTimeKind.Unspecified), "DmitriDulidenko@gmail.com", "Дмитрий", "Дулиденко", "Степанович", "+375(33)452-83-97", 0 },
                    { 13, new DateTime(1998, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2021, 8, 16, 19, 22, 38, 0, DateTimeKind.Unspecified), "StepanHoroshigin@gmail.com", "Степан", "Хорошигин", "Григорьевич", "+375(29)455-62-38", 1 },
                    { 32, new DateTime(1999, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new DateTime(2021, 9, 8, 19, 44, 1, 0, DateTimeKind.Unspecified), "UlianaFominova@gmail.com", "Ульяна", "Фоминова", "Степановна", "+375(33)466-99-18", 0 },
                    { 31, new DateTime(1998, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new DateTime(2021, 9, 8, 12, 10, 5, 0, DateTimeKind.Unspecified), "StepanPrilneshev@gmail.com", "Степан", "Прильнешев", "Олегович", "+375(33)911-13-66", 0 },
                    { 17, new DateTime(1994, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, new DateTime(2021, 8, 23, 16, 52, 30, 0, DateTimeKind.Unspecified), "KarolinaLutsko@gmail.com", "Каролина", "Луцко", "Степановна", "+375(33)754-39-45", 0 },
                    { 7, new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2021, 8, 15, 9, 34, 5, 0, DateTimeKind.Unspecified), "IgorUrigoev@gmail.com", "Игорь", "Уригоев", "Александрович", "+375(29)129-45-78", 1 },
                    { 1, new DateTime(1998, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2021, 8, 12, 14, 28, 36, 0, DateTimeKind.Unspecified), "IvanIvanov@gmail.com", "Иван", "Иванов", "Иванович", "+375(29)888-88-88", 1 },
                    { 26, new DateTime(1995, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, new DateTime(2021, 9, 5, 10, 32, 47, 0, DateTimeKind.Unspecified), "DariaJhinko@gmail.com", "Дарья", "Жинко", "Алексеевна", "+375(29)753-19-73", 0 },
                    { 20, new DateTime(1996, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, new DateTime(2021, 8, 29, 16, 4, 43, 0, DateTimeKind.Unspecified), "VitaliTsilenko@gmail.com", "Виталий", "Цыленко", "Викторович", "+375(33)668-94-15", 0 },
                    { 16, new DateTime(1991, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 8, 19, 13, 42, 9, 0, DateTimeKind.Unspecified), "GalinaKlimenko@gmail.com", "Галина", "Клименко", "Федоровна", "+375(29)149-75-63", 1 },
                    { 14, new DateTime(1992, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 8, 17, 7, 1, 54, 0, DateTimeKind.Unspecified), "VictoriaKlim@gmail.com", "Виктория", "Клим", "Андреевна", "+375(29)842-97-31", 1 },
                    { 11, new DateTime(1999, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 8, 16, 16, 4, 58, 0, DateTimeKind.Unspecified), "AndleiBurkin@gmail.com", "Андрей", "Буркин", "Петрович", "+375(29)982-76-78", 1 },
                    { 23, new DateTime(1995, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, new DateTime(2021, 9, 3, 12, 41, 3, 0, DateTimeKind.Unspecified), "StanislavBurinovich@gmail.com", "Станислав", "Буринович", "Владимирович", "+375(33)523-64-79", 0 },
                    { 8, new DateTime(1994, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 8, 15, 13, 2, 47, 0, DateTimeKind.Unspecified), "KateAltova@gmail.com", "Екатерина", "Альтова", "Станиславовна", "+375(29)852-36-14", 1 },
                    { 29, new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2021, 9, 6, 21, 14, 28, 0, DateTimeKind.Unspecified), "JannaIsotova@gmail.com", "Жанна", "Исотова", "Ивановна", "+375(29)219-67-80", 0 },
                    { 24, new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2021, 9, 3, 13, 0, 28, 0, DateTimeKind.Unspecified), "OlgaGulikova@gmail.com", "Ольга", "Гуликова", "Евгеньевна", "+375(29)428-83-91", 0 },
                    { 22, new DateTime(1991, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2021, 9, 1, 19, 28, 10, 0, DateTimeKind.Unspecified), "KirillSorokin@gmail.com", "Кирилл", "Сорокин", "Сергеевич", "+375(29)741-39-82", 0 },
                    { 18, new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(2021, 8, 24, 6, 15, 49, 0, DateTimeKind.Unspecified), "LeonidKulichko@gmail.com", "Леонид", "Куличко", "Игоревич", "+375(29)423-28-28", 0 },
                    { 10, new DateTime(1997, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, new DateTime(2021, 8, 16, 11, 3, 16, 0, DateTimeKind.Unspecified), "DmitriKrilov@gmail.com", "Дмитрий", "Крылов", "Иванович", "+375(29)782-22-19", 1 },
                    { 3, new DateTime(1999, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2021, 8, 13, 8, 36, 54, 0, DateTimeKind.Unspecified), "OlgaSinicina@gmail.com", "Ольга", "Синицина", "Дмитриевна", "+375(33)776-54-32", 1 },
                    { 33, new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2021, 9, 9, 9, 13, 21, 0, DateTimeKind.Unspecified), "IrinaHoiko@gmail.com", "Ирина", "Хойко", "Леонидовна", "+375(29)515-74-82", 0 },
                    { 30, new DateTime(1990, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2021, 9, 7, 16, 3, 45, 0, DateTimeKind.Unspecified), "IvanFedin@gmail.com", "Иван", "Федин", "Викторович", "+375(29)423-61-77", 0 },
                    { 27, new DateTime(1997, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2021, 9, 5, 13, 3, 8, 0, DateTimeKind.Unspecified), "BorisUliukin@gmail.com", "Борис", "Урюкин", "Федорович", "+375(29)456-64-45", 0 },
                    { 21, new DateTime(1996, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2021, 9, 1, 10, 36, 47, 0, DateTimeKind.Unspecified), "DmitriVakuliniko@gmail.com", "Дмитрий", "Вакулинико", "Александрович", "+375(33)246-80-62", 0 },
                    { 19, new DateTime(1992, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(2021, 8, 25, 14, 12, 1, 0, DateTimeKind.Unspecified), "PetrGromkov@gmail.com", "Петр", "Громков", "Владимирович", "+375(29)763-29-18", 0 },
                    { 12, new DateTime(1989, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2021, 8, 16, 18, 43, 30, 0, DateTimeKind.Unspecified), "SergeiZnakov@gmail.com", "Сергей", "Знаков", "Степанович", "+375(29)181-29-92", 1 },
                    { 6, new DateTime(1998, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2021, 8, 14, 20, 11, 6, 0, DateTimeKind.Unspecified), "IrinaEgorova@gmail.com", "Ирина", "Егорова", "Владимировна", "+375(29)875-65-32", 1 },
                    { 4, new DateTime(1998, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2021, 8, 13, 14, 59, 44, 0, DateTimeKind.Unspecified), "DariaVasnecova@gmail.com", "Дарья", "Васнецова", "Петровна", "+375(29)447-12-64", 1 },
                    { 5, new DateTime(1996, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2021, 8, 14, 10, 54, 31, 0, DateTimeKind.Unspecified), "SergeiKurablev@gmail.com", "Сергей", "Кураблев", "Иванович", "+375(29)987-16-48", 1 },
                    { 25, new DateTime(1997, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, new DateTime(2021, 9, 4, 17, 54, 11, 0, DateTimeKind.Unspecified), "LeonidTelenkov@gmail.com", "Леонид", "Теленков", "Владимирович", "+375(29)891-21-73", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CourseId",
                table: "Requests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsGroups_TeacherId",
                table: "StudentsGroups",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "StudentsGroups");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
