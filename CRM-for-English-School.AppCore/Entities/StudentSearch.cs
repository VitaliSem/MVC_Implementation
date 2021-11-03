using CRM_for_English_School.AppCore.Enums;

namespace CRM_for_English_School.AppCore.Entities
{
    public class StudentSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnglishLevel[] EnglishLevel { get; set; }
        public StudentStatus Status { get; set; }
        public int? AgeLowBorder { get; set; }
        public int? AgeHighBorder { get; set; }
        public int? GroupId { get; set; }
        public StudentsGroup StudentsGroup { get; set; }
    }
}
