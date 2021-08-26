using CRM_for_English_School.BLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Context
{
    public class EnglishSchoolContext : IdentityDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentsGroup> StudentsGroups { get; set; }

        public EnglishSchoolContext() { }
        public EnglishSchoolContext(DbContextOptions<EnglishSchoolContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student 
                    {
                        ID = 1,
                        LastName = "Иванов",
                        FirstName = "Иван",
                        MiddleName = "Иванович",
                        Age = 23,
                        Gender = Gender.Male,
                        CurrentEnglishLevel = "Elementary"
                    },
                    new Student {
                        ID = 2,
                        LastName = "Петров",
                        FirstName = "Петр",
                        MiddleName = "Петрович",
                        Age = 28,
                        Gender = Gender.Male,
                        CurrentEnglishLevel = "Pre-Intermediate"
                    },
                    new Student {
                        ID = 3,
                        LastName = "Синичкина",
                        FirstName = "Ольга",
                        MiddleName = "Дмитриевна",
                        Age = 24,
                        Gender = Gender.Female,
                        CurrentEnglishLevel = "Intermediate"
                    },
                    new Student {
                        ID = 4,
                        LastName = "Васнецов",
                        FirstName = "Виктор",
                        MiddleName = "Борисович",
                        Age = 25,
                        Gender = Gender.Male,
                        CurrentEnglishLevel = "Intermediate"
                    },
                    new Student {
                        ID = 5,
                        LastName = "Прокофьева",
                        FirstName = "Дарья",
                        MiddleName = "Петровна", 
                        Age = 23,
                        Gender = Gender.Female,
                        CurrentEnglishLevel = "Elementary"
                    },
                });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher[]
                {
                    new Teacher
                    {
                        ID = 1,
                        LastName = "Синицина",
                        FirstName = "Светлана",
                        MiddleName = "Викторовна",
                        Age = 32,
                        Gender = Gender.Female,
                        GraduatedFrom = "MSLU",
                        Degree = "Bachelor",
                        MainSpecialization = "English language history"
                    },
                    new Teacher
                    {
                        ID = 2,
                        LastName = "Кузнецова",
                        FirstName = "Екатерина",
                        MiddleName = "Степановна",
                        Age = 37,
                        Gender = Gender.Female,
                        GraduatedFrom = "BSU",
                        Degree = "Master",
                        MainSpecialization = "Linguistics"

                    }
                });
        }
    }
}
