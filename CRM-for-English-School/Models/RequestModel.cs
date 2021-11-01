using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using System;

namespace CRM_for_English_School.Models
{
    public class RequestModel : PersonModel
    {
        public int Id { get; set; }
        public DateTime DateOfRequest { get; set; } = DateTime.Now;
        public RequestStatus RequestStatus { get; set; }
        public EnglishLevel? CurrentEnglishLevel { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }

    }
}
