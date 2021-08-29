using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Entities
{
    public class StudentsGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
