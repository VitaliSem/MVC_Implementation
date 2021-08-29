using CRM_for_English_School.BLL.Entities;
using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Models
{
    public class StudentModel : PersonModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Isn't specified")]
        public string CurrentEnglishLevel { get; set; }
        public int GroupId { get; set; }
        public StudentsGroup Group { get; set; }
    }
}
