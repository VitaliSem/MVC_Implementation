using CRM_for_English_School.BLL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void RequestsSeed(this ModelBuilder modelBuilder)
        {
            Request[] requests = new Request[16];
            requests[0] = new Request
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
            requests[1] = new Request()
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
            requests[2] = new Request()
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
            requests[3] = new Request()
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
            requests[4] = new Request()
            {
                Id = 5,
                FirstName = "Сергей",
                MiddleName = "Иванович",
                LastName = "Кураблев",
                Age = 25,
                PhoneNumber = "+375(29)987-16-48",
                Email = "SergeiKurablev@gmail.com",
                Status = Status.Pending
            };
            requests[5] = new Request()
            {
                Id = 6,
                FirstName = "Ирина",
                MiddleName = "Владимировна",
                LastName = "Егорова",
                Age = 23,
                PhoneNumber = "+375(29)875-65-32",
                Email = "IrinaEgorova@gmail.com",
                Status = Status.Pending
            };
            requests[6] = new Request()
            {
                Id = 7,
                FirstName = "Игорь",
                MiddleName = "Александрович",
                LastName = "Уригоев",
                Age = 21,
                PhoneNumber = "+375(29)129-45-78",
                Email = "IgorUrigoev@gmail.com",
                Status = Status.Pending
            };
            requests[7] = new Request()
            {
                Id = 8,
                FirstName = "Екатерина",
                MiddleName = "Станиславовна",
                LastName = "Альтова",
                Age = 27,
                PhoneNumber = "+375(29)852-36-14",
                Email = "KateAltova@gmail.com",
                Status = Status.Pending
            };
            requests[8] = new Request()
            {
                Id = 9,
                FirstName = "Светлана",
                MiddleName = "Викторовна",
                LastName = "Заликова",
                Age = 25,
                PhoneNumber = "+375(29)752-86-19",
                Email = "SvetlanaZalikova@gmail.com",
                Status = Status.Pending
            };
            requests[9] = new Request()
            {
                Id = 10,
                FirstName = "Дмитрий",
                MiddleName = "Иванович",
                LastName = "Крылов",
                Age = 24,
                PhoneNumber = "+375(29)782-22-19",
                Email = "DmitriKrilov@gmail.com",
                Status = Status.Pending
            };
            requests[10] = new Request()
            {
                Id = 11,
                FirstName = "Андрей",
                MiddleName = "Петрович",
                LastName = "Буркин",
                Age = 22,
                PhoneNumber = "+375(29)982-76-78",
                Email = "AndleiBurkin@gmail.com",
                Status = Status.Pending
            };
            requests[11] = new Request()
            {
                Id = 12,
                FirstName = "Сергей",
                MiddleName = "Степанович",
                LastName = "Знаков",
                Age = 32,
                PhoneNumber = "+375(29)181-29-92",
                Email = "SergeiZnakov@gmail.com",
                Status = Status.Pending
            };
            requests[12] = new Request()
            {
                Id = 13,
                FirstName = "Степан",
                MiddleName = "Григорьевич",
                LastName = "Хорошигин",
                Age = 23,
                PhoneNumber = "+375(29)455-62-38",
                Email = "StepanHoroshigin@gmail.com",
                Status = Status.Pending
            };
            requests[13] = new Request()
            {
                Id = 14,
                FirstName = "Виктория",
                MiddleName = "Андреевна",
                LastName = "Клим",
                Age = 29,
                PhoneNumber = "+375(29)842-97-31",
                Email = "VictoriaKlim@gmail.com",
                Status = Status.Pending
            };
            requests[14] = new Request()
            {
                Id = 15,
                FirstName = "Федор",
                MiddleName = "Ильич",
                LastName = "Курабенко",
                Age = 26,
                PhoneNumber = "+375(29)872-96-42",
                Email = "FedorKurabenko@gmail.com",
                Status = Status.Pending
            };
            requests[15] = new Request()
            {
                Id = 16,
                FirstName = "Галина",
                MiddleName = "Федоровна",
                LastName = "Клименко",
                Age = 30,
                PhoneNumber = "+375(29)149-75-63",
                Email = "GalinaKlimenko@gmail.com",
                Status = Status.Pending
            };

            modelBuilder.Entity<Request>().HasData(requests);
        }
    }
}
