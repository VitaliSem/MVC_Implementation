using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Models
{
    public class StudentModel : PersonModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="The current english level is not specified.")]
        public string CurrentEnglishLevel { get; set; }
    }
}
