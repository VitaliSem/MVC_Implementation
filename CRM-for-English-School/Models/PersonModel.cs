using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.Validation;
using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage = "The first name is not specified")]
        [StringLength(maximumLength:30,ErrorMessage = "The FirstName field's length must be less than 30 symbols!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="The middle name is not specified.")]
        [StringLength(maximumLength: 30, ErrorMessage = "The MiddleName field's lengthmust be less than 30 symbols!")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage ="The last name is not specified.")]
        [StringLength(maximumLength: 30, ErrorMessage = "The LastName field's lengthmust be less than 30 symbols!")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="The Age is not specified.")]
        [Age]
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}