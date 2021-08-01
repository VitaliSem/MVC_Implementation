using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}