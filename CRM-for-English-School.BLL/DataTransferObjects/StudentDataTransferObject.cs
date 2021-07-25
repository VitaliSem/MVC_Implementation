using CRM_for_English_School.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.DataTransportObjects
{
    class StudentDataTransferObject : PersonDataTransferObject
    {
        public int StudentID { get; set; }
        public string CurrentEnglishLevel { get; set; }
    }
}
