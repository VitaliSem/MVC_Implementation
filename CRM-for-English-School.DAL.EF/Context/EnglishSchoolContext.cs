using CRM_for_English_School.BLL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Context
{
    public class EnglishSchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentsGroup> StudentsGroups { get; set; }

        public EnglishSchoolContext() { }
        public EnglishSchoolContext(DbContextOptions<EnglishSchoolContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EnglishSchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student { ID = 1, LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Age = 23, Gender = Gender.Male, CurrentEnglishLevel = "Elementary"},
                    new Student { ID = 2, LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", Age = 28, Gender = Gender.Male, CurrentEnglishLevel = "Pre-Intermediate"},
                    new Student { ID = 3, LastName = "Синичкина", FirstName = "Ольга", MiddleName = "Дмитриевна", Age = 24, Gender = Gender.Female, CurrentEnglishLevel = "Intermediate"},
                    new Student { ID = 4, LastName = "Васнецов", FirstName = "Виктор", MiddleName = "Борисович", Age = 25, Gender = Gender.Male, CurrentEnglishLevel = "Intermediate"},
                    new Student { ID = 5, LastName = "Прокофьева", FirstName = "Дарья", MiddleName = "Петровна", Age = 23, Gender = Gender.Female, CurrentEnglishLevel = "Elementary"},

                });
        }
    }
}
