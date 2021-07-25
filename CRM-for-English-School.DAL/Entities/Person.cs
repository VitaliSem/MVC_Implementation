using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.DAL.Entities
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
