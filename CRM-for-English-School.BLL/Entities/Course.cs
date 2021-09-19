using System;

namespace CRM_for_English_School.BLL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } //Course уже есть в названии курса
        public EnglishLevel EnglishLevel { get; set; }
        public DateTime ExpectedStartDate { get; set; }
    }
}
