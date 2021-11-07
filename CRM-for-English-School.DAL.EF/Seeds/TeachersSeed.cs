using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void TeachersSeed(this ModelBuilder modelBuilder)
        {
            var teacher1 = new Teacher()
            {
                UserId = new Guid("18fedd72-d3e2-4033-9744-877b60a5a2ff"),
                Id = 1,
                FirstName = "Светлана",
                MiddleName = "Георгиевна",
                LastName = "Федорова",
                BirthDate = new DateTime(1986, 11, 9),
                PhoneNumber = "+375(29)654-45-67",
                Email = "SvetlanaFedorova@gmail.com",
                Degree = Degree.Master,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Теоретическая и прикладная лингвистика",
                Groups = null,
                HasPhoto =  false,
                Photo = null,
                User = null
            };
            var teacher2 = new Teacher()
            {
                UserId = new Guid("2aa85a78-dba9-49d8-8215-89f793f1fd74"),
                Id = 2,
                FirstName = "Екатерина",
                MiddleName = "Викторовна",
                LastName = "Калинина",
                BirthDate = new DateTime(1992, 3, 1),
                PhoneNumber = "+375(33)151-16-19",
                Email = "KateKalinina@gmail.com",
                Degree = Degree.Bachelor,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Современные иностранные языки",
                Groups = null,
                HasPhoto = false,
                Photo = null,
                User = null
            };
            var teacher3 = new Teacher()
            {
                UserId = new Guid("465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9"),
                Id = 3,
                FirstName = "Ирина",
                MiddleName = "Андреевна",
                LastName = "Ступко",
                BirthDate = new DateTime(1994, 7, 14),
                PhoneNumber = "+375(33)742-86-95",
                Email = "IrinaStupco@gmail.com",
                Degree = Degree.Bachelor,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Современные иностранные языки",
                Groups = null,
                HasPhoto = false,
                Photo = null,
                User = null
            };
            var teacher4 = new Teacher()
            {
                UserId = new Guid("008120a7-6d9c-4f2e-83aa-52764cc6e3b7"),
                Id = 4,
                FirstName = "Ксения",
                MiddleName = "Петровна",
                LastName = "Фурсина",
                BirthDate = new DateTime(1990, 8, 12),
                PhoneNumber = "+375(33)87565-41",
                Email = "KseniaFursina@gmail.com",
                Degree = Degree.Master,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Теоретическая и прикладная лингвистика",
                Groups = null,
                HasPhoto = false,
                Photo = null,
                User = null
            };

            modelBuilder.Entity<Teacher>().HasData(teacher1, teacher2, teacher3, teacher4);
        }
    }
}
