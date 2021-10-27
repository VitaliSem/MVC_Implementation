using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Tests
{
    class RequestSearchTests
    {
        private EnglishSchoolContext _context;
        private RequestRepository requestRepository;
        [SetUp]
        public void Setup()
        {
            var DBContextOptions = new DbContextOptionsBuilder<EnglishSchoolContext>()
                .UseInMemoryDatabase("TestDB").Options;
            _context = new EnglishSchoolContext(DBContextOptions);
            SeedRequests(_context);

        requestRepository = new RequestRepository(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
        }
        [Test]
        public void SearchAsync_ReturnsAllEntities_WhenGetsNullableRequest()
        {
            //Arrange
            RequestSearch request = new();
            //Act
            var results = requestRepository.SearchAsync(request);
            //Assert
            Assert.IsInstanceOf(typeof(Task<List<Request>>), results);
            Assert.AreEqual(_context.Requests.CountAsync().Result, results.Result.Count);
        }

        [TestCase("Ольга", "Синицина")]
        [TestCase("ольга", "Синицина")]
        [TestCase("Ольга", "синицина")]
        [TestCase(null, "Синицина")]
        [TestCase("Ольга", null)]
        public void SearchAsync_ReturnsEntity_WhenGetsIgnoreCaseRequest(string firstName, string lastName)
        {
            //Arrang
            RequestSearch request = new()
            {
                FirstName = firstName,
                LastName = lastName
            };
            //Act
            var result = requestRepository.SearchAsync(request);
            //Assert
            Assert.AreEqual(1, result.Result.Count);
            Assert.AreEqual("Ольга", result.Result.Find(r => r.FirstName == "Ольга").FirstName);
            Assert.AreEqual("Синицина", result.Result.Find(r => r.LastName == "Синицина").LastName);
        }

        [TestCase(23,25)]
        [TestCase(23,null)]
        [TestCase(null,23)]
        public void SearchAsync_ReturnsEntityByAge_WhenGetsValidAgeRange(int? lowBorder, int? highBorder)
        {
            //Arrange
            RequestSearch request = new()
            {
                AgeLowBorder = lowBorder,
                AgeHighBorder = highBorder
            };
            //Act
            var results = requestRepository.SearchAsync(request);
            //Assert
            Assert.AreEqual(3, results.Result.Count);
        }
        [Test]
        public void SearchAsync_ThrowsException_WhenGetsInvalidAgeRange()
        {
            //Arrange
            RequestSearch request = new()
            {
                AgeLowBorder = 25,
                AgeHighBorder = 23
            };

            //Assert
            Assert.ThrowsAsync<ArgumentException>(() => requestRepository.SearchAsync(request));
        }
        private void SeedRequests(EnglishSchoolContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var requests = new List<Request>
            {
                new Request
                {
                    Id = 1,
                    FirstName = "Иван",
                    MiddleName = "Иванович",
                    LastName = "Иванов",
                    BirthDate = new DateTime(1998, 4, 11),
                    Age = 23,
                    PhoneNumber = "+375(29)888-88-88",
                    Email = "IvanIvanov@gmail.com",
                    DateOfRequest = new DateTime(2021, 8, 12, 14, 28, 36),
                    CurrentEnglishLevel = EnglishLevel.PreIntermediate,
                    CourseId = 4,
                    RequestStatus = RequestStatus.Confirmed
                },
                new Request()
                {
                    Id = 2,
                    FirstName = "Петр",
                    MiddleName = "Петрович",
                    LastName = "Петров",
                    BirthDate = new DateTime(1996, 12, 18),
                    Age = 25,
                    PhoneNumber = "+375(33)454-44-55",
                    Email = "PetrPetrov@gmail.com",
                    DateOfRequest = new DateTime(2021, 8, 12, 20, 11, 6),
                    CurrentEnglishLevel = EnglishLevel.Elementary,
                    CourseId = 1,
                    RequestStatus = RequestStatus.Confirmed
                },
                new Request()
                {
                    Id = 3,
                    FirstName = "Ольга",
                    MiddleName = "Дмитриевна",
                    LastName = "Синицина",
                    BirthDate = new DateTime(1999, 6, 3),
                    Age = 22,
                    PhoneNumber = "+375(33)776-54-32",
                    Email = "OlgaSinicina@gmail.com",
                    DateOfRequest = new DateTime(2021, 8, 13, 8, 36, 54),
                    CurrentEnglishLevel = EnglishLevel.Intermediate,
                    CourseId = 2,
                    RequestStatus = RequestStatus.Confirmed
                },
                new Request()
                {
                    Id = 4,
                    FirstName = "Дарья",
                    MiddleName = "Петровна",
                    LastName = "Васнецова",
                    BirthDate = new DateTime(1998, 9, 28),
                    Age = 23,
                    PhoneNumber = "+375(29)447-12-64",
                    Email = "DariaVasnecova@gmail.com",
                    DateOfRequest = new DateTime(2021, 8, 13, 14, 59, 44),
                    CurrentEnglishLevel = EnglishLevel.Elementary,
                    CourseId = 1,
                    RequestStatus = RequestStatus.Confirmed
                }
            };
            _context.Requests.AddRange(requests);
            _context.SaveChanges();
        }
    }
}
