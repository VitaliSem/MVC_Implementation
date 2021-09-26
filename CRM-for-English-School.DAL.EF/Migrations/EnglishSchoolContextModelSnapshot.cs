﻿// <auto-generated />
using System;
using CRM_for_English_School.DAL.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    [DbContext(typeof(EnglishSchoolContext))]
    partial class EnglishSchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnglishLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpectedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnglishLevel = 1,
                            ExpectedStartDate = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Анлийский для взрослых - PI_1"
                        },
                        new
                        {
                            Id = 2,
                            EnglishLevel = 2,
                            ExpectedStartDate = new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Английский для бизнеса - B-I_1"
                        },
                        new
                        {
                            Id = 3,
                            EnglishLevel = 3,
                            ExpectedStartDate = new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Английский для взрослых - UI_1"
                        },
                        new
                        {
                            Id = 4,
                            EnglishLevel = 2,
                            ExpectedStartDate = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Английский для взрослых - I_1"
                        },
                        new
                        {
                            Id = 5,
                            EnglishLevel = 0,
                            ExpectedStartDate = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Английский для взрослых - E_1"
                        },
                        new
                        {
                            Id = 6,
                            EnglishLevel = 0,
                            ExpectedStartDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Английский для бизнеса - B-E_1"
                        });
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrentEnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1998, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "IvanIvanov@gmail.com",
                            FirstName = "Иван",
                            LastName = "Иванов",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)888-88-88",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "PetrPetrov@gmail.com",
                            FirstName = "Петр",
                            LastName = "Петров",
                            MiddleName = "Петрович",
                            PhoneNumber = "+375(33)454-44-55",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1999, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "OlgaSinicina@gmail.com",
                            FirstName = "Ольга",
                            LastName = "Синицина",
                            MiddleName = "Дмитриевна",
                            PhoneNumber = "+375(33)776-54-32",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1998, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "DariaVasnecova@gmail.com",
                            FirstName = "Дарья",
                            LastName = "Васнецова",
                            MiddleName = "Петровна",
                            PhoneNumber = "+375(29)447-12-64",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1996, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "SergeiKurablev@gmail.com",
                            FirstName = "Сергей",
                            LastName = "Кураблев",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)987-16-48",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1998, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "IrinaEgorova@gmail.com",
                            FirstName = "Ирина",
                            LastName = "Егорова",
                            MiddleName = "Владимировна",
                            PhoneNumber = "+375(29)875-65-32",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "IgorUrigoev@gmail.com",
                            FirstName = "Игорь",
                            LastName = "Уригоев",
                            MiddleName = "Александрович",
                            PhoneNumber = "+375(29)129-45-78",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1994, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "KateAltova@gmail.com",
                            FirstName = "Екатерина",
                            LastName = "Альтова",
                            MiddleName = "Станиславовна",
                            PhoneNumber = "+375(29)852-36-14",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(1996, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "SvetlanaZalikova@gmail.com",
                            FirstName = "Светлана",
                            LastName = "Заликова",
                            MiddleName = "Викторовна",
                            PhoneNumber = "+375(29)752-86-19",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(1997, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "DmitriKrilov@gmail.com",
                            FirstName = "Дмитрий",
                            LastName = "Крылов",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)782-22-19",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 11,
                            BirthDate = new DateTime(1999, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "AndleiBurkin@gmail.com",
                            FirstName = "Андрей",
                            LastName = "Буркин",
                            MiddleName = "Петрович",
                            PhoneNumber = "+375(29)982-76-78",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 12,
                            BirthDate = new DateTime(1989, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "SergeiZnakov@gmail.com",
                            FirstName = "Сергей",
                            LastName = "Знаков",
                            MiddleName = "Степанович",
                            PhoneNumber = "+375(29)181-29-92",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 13,
                            BirthDate = new DateTime(1998, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "StepanHoroshigin@gmail.com",
                            FirstName = "Степан",
                            LastName = "Хорошигин",
                            MiddleName = "Григорьевич",
                            PhoneNumber = "+375(29)455-62-38",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 14,
                            BirthDate = new DateTime(1992, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "VictoriaKlim@gmail.com",
                            FirstName = "Виктория",
                            LastName = "Клим",
                            MiddleName = "Андреевна",
                            PhoneNumber = "+375(29)842-97-31",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 15,
                            BirthDate = new DateTime(1995, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "FedorKurabenko@gmail.com",
                            FirstName = "Федор",
                            LastName = "Курабенко",
                            MiddleName = "Ильич",
                            PhoneNumber = "+375(29)872-96-42",
                            RequestStatus = 0
                        },
                        new
                        {
                            Id = 16,
                            BirthDate = new DateTime(1991, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "GalinaKlimenko@gmail.com",
                            FirstName = "Галина",
                            LastName = "Клименко",
                            MiddleName = "Федоровна",
                            PhoneNumber = "+375(29)149-75-63",
                            RequestStatus = 0
                        });
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentEnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("GroupdId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1998, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "KonstantinKvaskov@gmail.com",
                            FirstName = "Константин",
                            GroupdId = 0,
                            LastName = "Квасков",
                            MiddleName = "Игоревич",
                            PhoneNumber = "+375(29)616-94-87"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "OlgaLabudco@gmail.com",
                            FirstName = "Ольга",
                            GroupdId = 0,
                            LastName = "Лабудько",
                            MiddleName = "Петрович",
                            PhoneNumber = "+375(33)822-74-13"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1997, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "KateSoroka@gmail.com",
                            FirstName = "Екатерина",
                            GroupdId = 0,
                            LastName = "Сорока",
                            MiddleName = "Степановна",
                            PhoneNumber = "+375(33)555-66-77"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1993, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "IvanLikov@gmail.com",
                            FirstName = "Иван",
                            GroupdId = 0,
                            LastName = "Лыков",
                            MiddleName = "Федорович",
                            PhoneNumber = "+375(29)996-74-14"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1998, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "PolyGolubeva@gmail.com",
                            FirstName = "Полина",
                            GroupdId = 0,
                            LastName = "Голубева",
                            MiddleName = "Алексеевна",
                            PhoneNumber = "+375(29)622-74-74"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1994, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "SvetoslavOgorodnik@gmail.com",
                            FirstName = "Светослав",
                            GroupdId = 0,
                            LastName = "Огородник",
                            MiddleName = "Дмитриевич",
                            PhoneNumber = "+375(29)743-96-13"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "KristinaKarayl@gmail.com",
                            FirstName = "Кристина",
                            GroupdId = 0,
                            LastName = "Караул",
                            MiddleName = "Федоровна",
                            PhoneNumber = "+375(29)120-19-84"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1996, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentEnglishLevel = 2,
                            Email = "EugeniaAlbegova@gmail.com",
                            FirstName = "Евгения",
                            GroupdId = 0,
                            LastName = "Альбегова",
                            MiddleName = "Петровна",
                            PhoneNumber = "+375(29)545-75-75"
                        });
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentsGroups");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraduatedFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1986, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = 1,
                            Email = "SvetlanaFedorova@gmail.com",
                            FirstName = "Светлана",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Федорова",
                            MainSpecialization = "Теоретическая и прикладная лингвистика",
                            MiddleName = "Георгиевна",
                            PhoneNumber = "+375(29)654-45-67"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = 0,
                            Email = "KateKalinina@gmail.com",
                            FirstName = "Екатерина",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Калинина",
                            MainSpecialization = "Современные иностранные языки",
                            MiddleName = "Викторовна",
                            PhoneNumber = "+375(33)151-16-19"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1994, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = 0,
                            Email = "IrinaStupco@gmail.com",
                            FirstName = "Ирина",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Ступко",
                            MainSpecialization = "Современные иностранные языки",
                            MiddleName = "Андреевна",
                            PhoneNumber = "+375(33)742-86-95"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1990, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Degree = 1,
                            Email = "KseniaFursina@gmail.com",
                            FirstName = "Ксения",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Фурсина",
                            MainSpecialization = "Теоретическая и прикладная лингвистика",
                            MiddleName = "Петровна",
                            PhoneNumber = "+375(33)87565-41"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Student", b =>
                {
                    b.HasOne("CRM_for_English_School.BLL.Entities.StudentsGroup", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.HasOne("CRM_for_English_School.BLL.Entities.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Teacher", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
