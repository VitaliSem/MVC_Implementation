using System;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public List<Request> Requests { get; set; }
    }
}
