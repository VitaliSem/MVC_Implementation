namespace CRM_for_English_School.BLL.Entities
{
    public class Student : Person
    {
        public int Id { get; set; }
        public EnglishLevel CurrentEnglishLevel { get; set; }
        public int GroupdId { get; set; }
        public StudentsGroup Group { get; set; }
    }
}
