namespace CRM_for_English_School.Models
{
    public class TeacherModel : PersonModel
    {
        public int ID { get; set; }
        public string MainSpecialization { get; set; }
        public string GraduatedFrom { get; set; }
        public string Degree { get; set; }
    }
}
