using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Models
{
    public class StudentsGroupModel : PersonModel
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
