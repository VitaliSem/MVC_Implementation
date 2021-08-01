namespace CRM_for_English_School.Models
{
    public class StudentModel : PersonModel
    {
        public int StudentID { get; set; }
        public string CurrentEnglishLevel { get; set; }
    }
}
