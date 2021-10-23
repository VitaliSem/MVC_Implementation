using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void RequestsSeed(this ModelBuilder modelBuilder)
        {
            Request[] requests = new Request[33];
            requests[0] = new Request
            {
                Id = 1,
                FirstName = "Иван",
                MiddleName = "Иванович",
                LastName = "Иванов",
                BirthDate = new DateTime(1998, 4, 11),
                PhoneNumber = "+375(29)888-88-88",
                Email = "IvanIvanov@gmail.com",
                DateOfRequest = new DateTime(2021, 8, 12, 14, 28, 36),
                CurrentEnglishLevel = EnglishLevel.PreIntermediate,
                CourseId = 4,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 12, 20, 11, 6),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 1,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 13, 8, 36, 54),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 2,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 13, 14, 59, 44),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 1,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 14, 10, 54, 31),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 3,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 14, 20, 11, 6),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 1,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 15, 9, 34, 5),
                CurrentEnglishLevel = EnglishLevel.PreIntermediate,
                CourseId = 4,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 15, 13, 2, 47),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 3,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 15, 22, 9, 40),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 6,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 16, 11, 3, 16),
                CurrentEnglishLevel = EnglishLevel.PreIntermediate,
                CourseId = 2,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 16, 16, 4, 58),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 3,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8 , 16, 18, 43, 30),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 1,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 16, 19, 22, 38),
                CurrentEnglishLevel = EnglishLevel.PreIntermediate,
                CourseId = 5,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 17, 7, 1, 54),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 3,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 17, 19, 46, 32),
                CurrentEnglishLevel = EnglishLevel.Elementary,
                CourseId = 6,
                RequestStatus = RequestStatus.Confirmed
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
                DateOfRequest = new DateTime(2021, 8, 19, 13, 42, 9),
                CurrentEnglishLevel = EnglishLevel.Intermediate,
                CourseId = 3,
                RequestStatus = RequestStatus.Confirmed
            };
            requests[16] = new Request()
            {
                Id = 17,
                FirstName = "Каролина",
                MiddleName = "Степановна",
                LastName = "Луцко",
                BirthDate = new DateTime(1994, 7, 23),
                PhoneNumber = "+375(33)754-39-45",
                Email = "KarolinaLutsko@gmail.com",
                DateOfRequest = new DateTime(2021, 8, 23, 16, 52, 30),
                CourseId = 4,
                RequestStatus = RequestStatus.Pending
            };
            requests[17] = new Request()
            {
                Id = 18,
                FirstName = "Леонид",
                MiddleName = "Игоревич",
                LastName = "Куличко",
                BirthDate = new DateTime(1997, 11, 3),
                PhoneNumber = "+375(29)423-28-28",
                Email = "LeonidKulichko@gmail.com",
                DateOfRequest = new DateTime(2021, 8, 24, 6, 15, 49),
                CourseId = 2,
                RequestStatus = RequestStatus.Pending
            };
            requests[18] = new Request()
            {
                Id = 19,
                FirstName = "Петр",
                MiddleName = "Владимирович",
                LastName = "Громков",
                BirthDate = new DateTime(1992, 8, 14),
                PhoneNumber = "+375(29)763-29-18",
                Email = "PetrGromkov@gmail.com",
                DateOfRequest = new DateTime(2021, 8, 25, 14, 12, 1),
                CourseId = 1,
                RequestStatus = RequestStatus.Pending
            };
            requests[19] = new Request()
            {
                Id = 20,
                FirstName = "Виталий",
                MiddleName = "Викторович",
                LastName = "Цыленко",
                BirthDate = new DateTime(1996, 1, 15),
                PhoneNumber = "+375(33)668-94-15",
                Email = "VitaliTsilenko@gmail.com",
                DateOfRequest = new DateTime(2021, 8, 29, 16, 4, 43),
                CourseId = 3,
                RequestStatus = RequestStatus.Pending
            };
            requests[20] = new Request()
            {
                Id = 21,
                FirstName = "Дмитрий",
                MiddleName = "Александрович",
                LastName = "Вакулинико",
                BirthDate = new DateTime(1996, 6, 9),
                PhoneNumber = "+375(33)246-80-62",
                Email = "DmitriVakuliniko@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 1, 10, 36, 47),
                CourseId = 1,
                RequestStatus = RequestStatus.Pending
            };
            requests[21] = new Request()
            {
                Id = 22,
                FirstName = "Кирилл",
                MiddleName = "Сергеевич",
                LastName = "Сорокин",
                BirthDate = new DateTime(1991, 9, 5),
                PhoneNumber = "+375(29)741-39-82",
                Email = "KirillSorokin@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 1, 19, 28, 10),
                CourseId = 2,
                RequestStatus = RequestStatus.Pending
            };
            requests[22] = new Request()
            {
                Id = 23,
                FirstName = "Станислав",
                MiddleName = "Владимирович",
                LastName = "Буринович",
                BirthDate = new DateTime(1995, 5, 14),
                PhoneNumber = "+375(33)523-64-79",
                Email = "StanislavBurinovich@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 3, 12, 41, 3),
                CourseId = 6,
                RequestStatus = RequestStatus.Pending
            };
            requests[23] = new Request()
            {
                Id = 24,
                FirstName = "Ольга",
                MiddleName = "Евгеньевна",
                LastName = "Гуликова",
                BirthDate = new DateTime(1992, 10, 30),
                PhoneNumber = "+375(29)428-83-91",
                Email = "OlgaGulikova@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 3, 13, 0, 28),
                CourseId = 2,
                RequestStatus = RequestStatus.Pending
            };
            requests[24] = new Request()
            {
                Id = 25,
                FirstName = "Леонид",
                MiddleName = "Владимирович",
                LastName = "Теленков",
                BirthDate = new DateTime(1997, 4, 15),
                PhoneNumber = "+375(29)891-21-73",
                Email = "LeonidTelenkov@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 4, 17, 54, 11),
                CourseId = 6,
                RequestStatus = RequestStatus.Pending
            };
            requests[25] = new Request()
            {
                Id = 26,
                FirstName = "Дарья",
                MiddleName = "Алексеевна",
                LastName = "Жинко",
                BirthDate = new DateTime(1995, 12, 29),
                PhoneNumber = "+375(29)753-19-73",
                Email = "DariaJhinko@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 5, 10, 32, 47),
                CourseId = 3,
                RequestStatus = RequestStatus.Pending
            };
            requests[26] = new Request()
            {
                Id = 27,
                FirstName = "Борис",
                MiddleName = "Федорович",
                LastName = "Урюкин",
                BirthDate = new DateTime(1997, 3, 18),
                PhoneNumber = "+375(29)456-64-45",
                Email = "BorisUliukin@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 5, 13, 3, 8),
                CourseId = 1,
                RequestStatus = RequestStatus.Pending
            };
            requests[27] = new Request()
            {
                Id = 28,
                FirstName = "Дмитрий",
                MiddleName = "Степанович",
                LastName = "Дулиденко",
                BirthDate = new DateTime(1991, 4, 18),
                PhoneNumber = "+375(33)452-83-97",
                Email = "DmitriDulidenko@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 6, 18, 40, 31),
                CourseId = 5,
                RequestStatus = RequestStatus.Pending
            };
            requests[28] = new Request()
            {
                Id = 29,
                FirstName = "Жанна",
                MiddleName = "Ивановна",
                LastName = "Исотова",
                BirthDate = new DateTime(1994, 11, 17),
                PhoneNumber = "+375(29)219-67-80",
                Email = "JannaIsotova@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 6, 21, 14, 28),
                CourseId = 2,
                RequestStatus = RequestStatus.Pending
            };
            requests[29] = new Request()
            {
                Id = 30,
                FirstName = "Иван",
                MiddleName = "Викторович",
                LastName = "Федин",
                BirthDate = new DateTime(1990, 12, 7),
                PhoneNumber = "+375(29)423-61-77",
                Email = "IvanFedin@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 7, 16, 3, 45),
                CourseId = 1,
                RequestStatus = RequestStatus.Pending
            };
            requests[30] = new Request()
            {
                Id = 31,
                FirstName = "Степан",
                MiddleName = "Олегович",
                LastName = "Прильнешев",
                BirthDate = new DateTime(1998, 8, 14),
                PhoneNumber = "+375(33)911-13-66",
                Email = "StepanPrilneshev@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 8, 12, 10, 5),
                CourseId = 4,
                RequestStatus = RequestStatus.Pending
            };
            requests[31] = new Request()
            {
                Id = 32,
                FirstName = "Ульяна",
                MiddleName = "Степановна",
                LastName = "Фоминова",
                BirthDate = new DateTime(1999, 9, 28),
                PhoneNumber = "+375(33)466-99-18",
                Email = "UlianaFominova@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 8, 19, 44, 1),
                CourseId = 4,
                RequestStatus = RequestStatus.Pending
            };
            requests[32] = new Request()
            {
                Id = 33,
                FirstName = "Ирина",
                MiddleName = "Леонидовна",
                LastName = "Хойко",
                BirthDate = new DateTime(1994, 6, 19),
                PhoneNumber = "+375(29)515-74-82",
                Email = "IrinaHoiko@gmail.com",
                DateOfRequest = new DateTime(2021, 9, 9, 9, 13, 21),
                CourseId = 1,
                RequestStatus = RequestStatus.Pending
            };
            modelBuilder.Entity<Request>().HasData(requests);
        }
    }
}
