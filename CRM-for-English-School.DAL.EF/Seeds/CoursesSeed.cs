using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void CourcesSeed(this ModelBuilder modelBuilder)
        {
            Course[] courses = new Course[6];
            courses[0] = new Course()
            {
                Id = 1,
                Name = "Анлийский для взрослых - PI_1",
                EnglishLevel = EnglishLevel.PreIntermediate,
                ExpectedStartDate = new DateTime(2021, 11, 1),
                Price = 980
            };
            courses[1] = new Course()
            {
                Id = 2,
                Name = "Английский для бизнеса - B-I_1",
                EnglishLevel = EnglishLevel.Intermediate,
                ExpectedStartDate = new DateTime(2021, 11, 29),
                Price = 1180
            };
            courses[2] = new Course()
            {
                Id = 3,
                Name = "Английский для взрослых - UI_1",
                EnglishLevel = EnglishLevel.UpperIntermediate,
                ExpectedStartDate = new DateTime(2022, 2, 7),
                Price = 1180
            };
            courses[3] = new Course()
            {
                Id = 4,
                Name = "Английский для взрослых - I_2",
                EnglishLevel = EnglishLevel.Intermediate,
                ExpectedStartDate = new DateTime(2022, 2, 14),
                Price = 1030
            };
            courses[4] = new Course()
            {
                Id = 5,
                Name = "Английский для взрослых - I_1",
                EnglishLevel = EnglishLevel.Intermediate,
                ExpectedStartDate = new DateTime(2021, 12, 13),
                Price = 1030
            };
            courses[5] = new Course()
            {
                Id = 6,
                Name = "Английский для бизнеса - B-PI_1",
                EnglishLevel = EnglishLevel.PreIntermediate,
                ExpectedStartDate = new DateTime(2022, 1, 10),
                Price = 1030
            };

            modelBuilder.Entity<Course>().HasData(courses);
        }
    }
}
