using CRM_for_English_School.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.DAL.Context
{
    public class EnglishSchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public EnglishSchoolContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentsDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student { StudentID = 1, LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Age = 23, Gender = Gender.Male, CurrentEnglishLevel = "Elementary"},
                    new Student { StudentID = 2, LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", Age = 28, Gender = Gender.Male, CurrentEnglishLevel = "Pre-Intermediate"},
                    new Student { StudentID = 3, LastName = "Синичкина", FirstName = "Ольга", MiddleName = "Дмитриевна", Age = 24, Gender = Gender.Female, CurrentEnglishLevel = "Intermediate"},
                    new Student { StudentID = 4, LastName = "Васнецов", FirstName = "Виктор", MiddleName = "Борисович", Age = 25, Gender = Gender.Male, CurrentEnglishLevel = "Intermediate"},
                    new Student { StudentID = 5, LastName = "Прокофьева", FirstName = "Дарья", MiddleName = "Петровна", Age = 23, Gender = Gender.Female, CurrentEnglishLevel = "Elementary"},

                });
        }
    }
}
