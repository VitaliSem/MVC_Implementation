using CRM_for_English_School.AppCore.Enums;

namespace CRM_for_English_School.AppCore.Entities
{
    public class RequestSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnglishLevel[] CurrentEnglishLevel { get; set; }
        public int? AgeLowBorder { get; set; }
        public int? AgeHighBorder { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
