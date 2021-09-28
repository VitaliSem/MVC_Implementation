using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void StudentsSeed(this ModelBuilder modelBuilder)
        {
            Student[] students = new Student[8];
            students[0] = new Student
            {
                Id = 1,
                FirstName = "Константин",
                MiddleName = "Игоревич",
                LastName = "Квасков",
                BirthDate = new DateTime(1998, 8, 21),
                PhoneNumber = "+375(29)616-94-87",
                Email = "KonstantinKvaskov@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[1] = new Student
            {
                Id = 2,
                FirstName = "Ольга",
                MiddleName = "Петрович",
                LastName = "Лабудько",
                BirthDate = new DateTime(2000, 3, 17),
                PhoneNumber = "+375(33)822-74-13",
                Email = "OlgaLabudco@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[2] = new Student
            {
                Id = 3,
                FirstName = "Екатерина",
                MiddleName = "Степановна",
                LastName = "Сорока",
                BirthDate = new DateTime(1997, 11, 8),
                PhoneNumber = "+375(33)555-66-77",
                Email = "KateSoroka@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[3] = new Student
            {
                Id = 4,
                FirstName = "Иван",
                MiddleName = "Федорович",
                LastName = "Лыков",
                BirthDate = new DateTime(1993, 5, 19),
                PhoneNumber = "+375(29)996-74-14",
                Email = "IvanLikov@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[4] = new Student
            {
                Id = 5,
                FirstName = "Полина",
                MiddleName = "Алексеевна",
                LastName = "Голубева",
                BirthDate = new DateTime(1998, 4, 5),
                PhoneNumber = "+375(29)622-74-74",
                Email = "PolyGolubeva@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[5] = new Student
            {
                Id = 6,
                FirstName = "Светослав",
                MiddleName = "Дмитриевич",
                LastName = "Огородник",
                BirthDate = new DateTime(1994, 12, 30),
                PhoneNumber = "+375(29)743-96-13",
                Email = "SvetoslavOgorodnik@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[6] = new Student()
            {
                Id = 7,
                FirstName = "Кристина",
                MiddleName = "Федоровна",
                LastName = "Караул",
                BirthDate = new DateTime(1993, 6, 3),
                PhoneNumber = "+375(29)120-19-84",
                Email = "KristinaKarayl@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };
            students[7] = new Student()
            {
                Id = 8,
                FirstName = "Евгения",
                MiddleName = "Петровна",
                LastName = "Альбегова",
                BirthDate = new DateTime(1996, 4, 19),
                PhoneNumber = "+375(29)545-75-75",
                Email = "EugeniaAlbegova@gmail.com",
                CurrentEnglishLevel = EnglishLevel.Intermediate,
            };

            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}
