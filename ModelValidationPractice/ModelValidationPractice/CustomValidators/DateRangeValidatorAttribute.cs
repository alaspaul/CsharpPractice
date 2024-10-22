using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ModelValidationPractice.CustomValidators
{
    public class DateRangeValidatorAttribute : ValidationAttribute
    {
        public string OtherPropertyName;

        public string DefaultErrorMessage = "{0} should be greater than {1}";
        public DateRangeValidatorAttribute(string otherPropertyName) 
        { 
            OtherPropertyName = otherPropertyName;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
           if(value != null)
            {
                DateTime toDate = Convert.ToDateTime(value);
                PropertyInfo? otherProperty =
                    validationContext.ObjectType.GetProperty(OtherPropertyName);

                if (otherProperty != null)
                {
                    DateTime fromDate = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));

                    if (fromDate > toDate)
                    {
                        return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, validationContext.MemberName, OtherPropertyName));
                        return new ValidationResult(ErrorMessage, new string[]
                        { OtherPropertyName, validationContext.MemberName });
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }

                return null;
            }

            return null;
        }
    }
}
