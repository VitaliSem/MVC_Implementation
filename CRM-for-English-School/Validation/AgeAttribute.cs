using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Validation
{
    public class AgeAttribute : ValidationAttribute
    {
        private const int minAge = 12;
        private const int maxAge = 110;

        public override bool IsValid(object value)
        {
            return (int)value > minAge && (int)value < maxAge;
        }

    }
}
