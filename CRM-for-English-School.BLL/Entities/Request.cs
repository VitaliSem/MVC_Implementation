namespace CRM_for_English_School.BLL.Entities
{
    public class Request : Person
    {
        public int Id { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public EnglishLevel? CurrentEnglishLevel { get; set; }
        public Course Course { get; set; }
    }
}
