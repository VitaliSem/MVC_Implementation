using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CRM_for_English_School.Models
{
    public class StudentSearchModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnglishLevel[] EnglishLevel { get; set; }
        public StudentStatus Status { get; set; }
        public int? AgeLowBorder { get; set; }
        public int? AgeHighBorder { get; set; }
        public int? GroupId { get; set; }
        [BindNever]
        public StudentsGroup Group { get; set; }
    }
}
