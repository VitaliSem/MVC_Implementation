namespace CRM_for_English_School.BLL.Entities
{
    public class Teacher : Person
    {
        public int ID { get; set; }
        public string MainSpecialization { get; set; }
        public string GraduatedFrom { get; set; }
        public string Degree { get; set; }
    }
}
