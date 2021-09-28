using System;

namespace CRM_for_English_School.AppCore.Entities
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                if (BirthDate == DateTime.MinValue)
                {
                    return 0;
                }
                else
                {
                    return (DateTime.Now - BirthDate).Days / 365;
                }
            }
        }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
