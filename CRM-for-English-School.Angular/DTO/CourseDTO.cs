using CRM_for_English_School.AppCore.Enums;
using System;

namespace CRM_for_English_School.Angular.DTO
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public DateTime ExpectedStartDate { get; set; }
    }
}
