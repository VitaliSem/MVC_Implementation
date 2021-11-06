using System;

namespace CRM_for_English_School.AppCore.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public StudentsGroup Group { get; set; }
        public DateTime Date { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
    }
}
