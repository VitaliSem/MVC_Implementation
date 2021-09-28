using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;

namespace CRM_for_English_School.Models
{
    public class SearchModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnglishLevel CurrentEnglishLevel { get; set; }
        public int? AgeLowBorder { get; set; }
        public int? AgeHighBorder { get; set; }
        public Course Course { get; set; }
    }
}
