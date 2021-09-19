using CRM_for_English_School.BLL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

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
                BirthDate = new DateTime(1998, 4, 11),
                PhoneNumber = "+375(29)888-88-88",
                Email = "IvanIvanov@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[1] = new Request()
            {
                Id = 2,
                FirstName = "Петр",
                MiddleName = "Петрович",
                LastName = "Петров",
                BirthDate = new DateTime(1996, 12, 18),
                PhoneNumber = "+375(33)454-44-55",
                Email = "PetrPetrov@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[2] = new Request()
            {
                Id = 3,
                FirstName = "Ольга",
                MiddleName = "Дмитриевна",
                LastName = "Синицина",
                BirthDate = new DateTime(1999, 6, 3),
                PhoneNumber = "+375(33)776-54-32",
                Email = "OlgaSinicina@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[3] = new Request()
            {
                Id = 4,
                FirstName = "Дарья",
                MiddleName = "Петровна",
                LastName = "Васнецова",
                BirthDate = new DateTime(1998, 9, 28),
                PhoneNumber = "+375(29)447-12-64",
                Email = "DariaVasnecova@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[4] = new Request()
            {
                Id = 5,
                FirstName = "Сергей",
                MiddleName = "Иванович",
                LastName = "Кураблев",
                BirthDate = new DateTime(1996, 3, 21),
                PhoneNumber = "+375(29)987-16-48",
                Email = "SergeiKurablev@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[5] = new Request()
            {
                Id = 6,
                FirstName = "Ирина",
                MiddleName = "Владимировна",
                LastName = "Егорова",
                BirthDate = new DateTime(1998, 2, 13),
                PhoneNumber = "+375(29)875-65-32",
                Email = "IrinaEgorova@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[6] = new Request()
            {
                Id = 7,
                FirstName = "Игорь",
                MiddleName = "Александрович",
                LastName = "Уригоев",
                BirthDate = new DateTime(2000, 12, 3),
                PhoneNumber = "+375(29)129-45-78",
                Email = "IgorUrigoev@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[7] = new Request()
            {
                Id = 8,
                FirstName = "Екатерина",
                MiddleName = "Станиславовна",
                LastName = "Альтова",
                BirthDate = new DateTime(1994, 10, 13),
                PhoneNumber = "+375(29)852-36-14",
                Email = "KateAltova@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[8] = new Request()
            {
                Id = 9,
                FirstName = "Светлана",
                MiddleName = "Викторовна",
                LastName = "Заликова",
                BirthDate = new DateTime(1996, 4, 15),
                PhoneNumber = "+375(29)752-86-19",
                Email = "SvetlanaZalikova@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[9] = new Request()
            {
                Id = 10,
                FirstName = "Дмитрий",
                MiddleName = "Иванович",
                LastName = "Крылов",
                BirthDate = new DateTime(1997, 7, 1),
                PhoneNumber = "+375(29)782-22-19",
                Email = "DmitriKrilov@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[10] = new Request()
            {
                Id = 11,
                FirstName = "Андрей",
                MiddleName = "Петрович",
                LastName = "Буркин",
                BirthDate = new DateTime(1999, 11, 24),
                PhoneNumber = "+375(29)982-76-78",
                Email = "AndleiBurkin@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[11] = new Request()
            {
                Id = 12,
                FirstName = "Сергей",
                MiddleName = "Степанович",
                LastName = "Знаков",
                BirthDate = new DateTime(1989, 2, 22),
                PhoneNumber = "+375(29)181-29-92",
                Email = "SergeiZnakov@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[12] = new Request()
            {
                Id = 13,
                FirstName = "Степан",
                MiddleName = "Григорьевич",
                LastName = "Хорошигин",
                BirthDate = new DateTime(1998, 3, 18),
                PhoneNumber = "+375(29)455-62-38",
                Email = "StepanHoroshigin@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[13] = new Request()
            {
                Id = 14,
                FirstName = "Виктория",
                MiddleName = "Андреевна",
                LastName = "Клим",
                BirthDate = new DateTime(1992, 10, 3),
                PhoneNumber = "+375(29)842-97-31",
                Email = "VictoriaKlim@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[14] = new Request()
            {
                Id = 15,
                FirstName = "Федор",
                MiddleName = "Ильич",
                LastName = "Курабенко",
                BirthDate = new DateTime(1995, 9, 11),
                PhoneNumber = "+375(29)872-96-42",
                Email = "FedorKurabenko@gmail.com",
                RequestStatus = RequestStatus.Pending
            };
            requests[15] = new Request()
            {
                Id = 16,
                FirstName = "Галина",
                MiddleName = "Федоровна",
                LastName = "Клименко",
                BirthDate = new DateTime(1991, 6, 4),
                PhoneNumber = "+375(29)149-75-63",
                Email = "GalinaKlimenko@gmail.com",
                RequestStatus = RequestStatus.Pending
            };

            modelBuilder.Entity<Request>().HasData(requests);
        }
    }
}
