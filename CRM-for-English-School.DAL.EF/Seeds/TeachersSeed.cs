using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Enums;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void TeachersSeed(this ModelBuilder modelBuilder)
        {
            var teacher1 = new Teacher()
            {
                Id = 1,
                FirstName = "Светлана",
                MiddleName = "Георгиевна",
                LastName = "Федорова",
                Age = 35,
                PhoneNumber = "+375(29)654-45-67",
                Email = "SvetlanaFedorova@gmail.com",
                Degree = Degree.Master,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Теоретическая и прикладная лингвистика",
                Groups = null
            };
            var teacher2 = new Teacher()
            {
                Id = 2,
                FirstName = "Екатерина",
                MiddleName = "Викторовна",
                LastName = "Калинина",
                Age = 29,
                PhoneNumber = "+375(33)151-16-19",
                Email = "KateKalinina@gmail.com",
                Degree = Degree.Bachelor,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Современные иностранные языки",
                Groups = null
            };
            var teacher3 = new Teacher()
            {
                Id = 3,
                FirstName = "Ирина",
                MiddleName = "Андреевна",
                LastName = "Ступко",
                Age = 27,
                PhoneNumber = "+375(33)742-86-95",
                Email = "IrinaStupco@gmail.com",
                Degree = Degree.Bachelor,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Современные иностранные языки",
                Groups = null
            };
            var teacher4 = new Teacher()
            {
                Id = 4,
                FirstName = "Ксения",
                MiddleName = "Петровна",
                LastName = "Фурсина",
                Age = 31,
                PhoneNumber = "+375(33)87565-41",
                Email = "KseniaFursina@gmail.com",
                Degree = Degree.Master,
                GraduatedFrom = "МГЛУ",
                MainSpecialization = "Теоретическая и прикладная лингвистика",
                Groups = null
            };

            modelBuilder.Entity<Teacher>().HasData(teacher1, teacher2,teacher3,teacher4);
        }
    }
}
