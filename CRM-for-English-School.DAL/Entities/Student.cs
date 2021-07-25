using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.DAL.Entities
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public string CurrentEnglishLevel { get; set; }
    }
}
