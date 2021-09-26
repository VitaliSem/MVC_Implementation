using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Models
{
    public class RequestModel : PersonModel
    {
        public int Id { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public EnglishLevel? CurrentEnglishLevel { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }

    }
}
