using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.AppCore.Enums;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace CRM_for_English_School.Models
{
    public class TeacherModel : PersonModel
    {
        public int Id { get; set; }
        public string MainSpecialization { get; set; }
        public string GraduatedFrom { get; set; }
        public Degree Degree { get; set; }
        public List<StudentsGroup> Groups { get; set; }
        public IFormFile PhotoFile { get; set; }
        public byte[] Photo { get; set; }
        public bool HasPhoto { get; set; }
    }
}
