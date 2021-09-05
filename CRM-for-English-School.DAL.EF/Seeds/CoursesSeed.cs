using CRM_for_English_School.BLL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void CourcesSeed(this ModelBuilder modelBuilder)
        {
            var course1 = new Course()
            {
                Id = 1,
                CourseName = "English for Adults",
                EnglishLevel = EnglishLevel.Pre_Intermediate,
                ExpectedStartDate = new DateTime(2021, 11, 1)
            };

            var course2 = new Course()
            {
                Id = 2,
                CourseName = "English for Business",
                EnglishLevel = EnglishLevel.Intermediate,
                ExpectedStartDate = new DateTime(2021, 11, 29)
            };

            modelBuilder.Entity<Course>().HasData(course1, course2);
        }
    }
}
