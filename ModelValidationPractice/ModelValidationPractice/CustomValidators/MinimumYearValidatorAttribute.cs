using System.ComponentModel.DataAnnotations;

namespace ModelValidationPractice.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2001;
        public string DefaultErrorMessage { get; set; } = "Year should be greater than {0}"; // adding default error message
        public MinimumYearValidatorAttribute() 
        { 

        }

        public MinimumYearValidatorAttribute(int minimumYear)
        {
            MinimumYear = minimumYear; // adding minimum year as a parameter
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null) 
            {
                DateTime date = (DateTime)value;
                if (date.Year <= MinimumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, MinimumYear)); // adding minimum year as a parameter for {0}
                }
                else
                {
                    return ValidationResult.Success;
                }
            }

            return null;
        }
    }
}
