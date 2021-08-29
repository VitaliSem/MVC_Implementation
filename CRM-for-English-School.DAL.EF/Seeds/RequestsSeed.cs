using CRM_for_English_School.BLL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void RequestsSeed(this ModelBuilder modelBuilder)
        {
            var newRequest1 = new Request()
            {
                Id = 1,
                FirstName = "Иван",
                MiddleName = "Иванович",
                LastName = "Иванов",
                Age = 23,
                PhoneNumber = "+375(29)888-88-88",
                Email = "IvanIvanov@gmail.com",
                Status = Status.Pending
            };
            var newRequest2 = new Request()
            {
                Id = 2,
                FirstName = "Петр",
                MiddleName = "Петрович",
                LastName = "Петров",
                Age = 25,
                PhoneNumber = "+375(33)454-44-55",
                Email = "PetrPetrov@gmail.com",
                Status = Status.Pending
            };
            var newRequest3 = new Request()
            {
                Id = 3,
                FirstName = "Ольга",
                MiddleName = "Дмитриевна",
                LastName = "Синицина",
                Age = 22,
                PhoneNumber = "+375(33)776-54-32",
                Email = "OlgaSinicina@gmail.com",
                Status = Status.Pending
            };
            var newRequest4 = new Request()
            {
                Id = 4,
                FirstName = "Дарья",
                MiddleName = "Петровна",
                LastName = "Васнецова",
                Age = 23,
                PhoneNumber = "+375(29)447-12-64",
                Email = "DariaVasnecova@gmail.com",
                Status = Status.Pending
            };

            modelBuilder.Entity<Request>().HasData(newRequest1, newRequest2, newRequest3, newRequest4);
        }
    }
}
