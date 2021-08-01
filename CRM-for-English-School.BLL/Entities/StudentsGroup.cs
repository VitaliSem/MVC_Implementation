using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Entities
{
    public class StudentsGroup
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
