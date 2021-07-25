using CRM_for_English_School.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.DataTransferObjects
{
    public abstract class PersonDataTransferObject
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
