using CRM_for_English_School.AppCore.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CRM_for_English_School.AppCore.Entities
{
    public class Teacher : Person
    {
        public int Id { get; set; }
        public string MainSpecialization { get; set; }
        public string GraduatedFrom { get; set; }
        public Degree Degree { get; set; }
        public List<StudentsGroup> Groups { get; set; }
        public byte[] Photo { get; set; }
        public bool HasPhoto { get; set; }
        public Guid UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
