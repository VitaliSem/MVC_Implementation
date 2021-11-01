using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using CRM_for_English_School.Validation;
using System.Collections.Generic;

namespace CRM_for_English_School.Models
{
    public class StudentsGroupModel
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        [ArrayLength(3,5,"The number of students must be more then 3 and less than 5")]
        public List<int> RequestIds { get; set; }
        public List<Student> Students { get; set; }
    }
}
