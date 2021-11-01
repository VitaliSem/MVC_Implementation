using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Validation
{
    public class ArrayLengthAttribute : ValidationAttribute
    {
        private readonly int _minLength;
        private readonly int _maxLength;
        public ArrayLengthAttribute(int minLength, int maxLength, string errorMessage) : base(errorMessage)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var list = (List<int>)value;
            if (list.Count < _minLength || list.Count > _maxLength)
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;
        }
    }
}
