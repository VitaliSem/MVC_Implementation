using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using System.Collections.Generic;

namespace CRM_for_English_School.Models
{
    public class StudentsGroupModel
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
