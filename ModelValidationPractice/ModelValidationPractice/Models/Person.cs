using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelValidationPractice.CustomValidators;

namespace ModelValidationPractice.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "Name is Empty")]
        [RegularExpression("^[A-Za-z .]*$")]
        [Display(Name = "Person Name")]                     // {0} is property name  {2} is minimum length {1} is max length
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} should be between {2} and {1}")]
       public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "{0} should have email")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "{0} number should be xxx-xxx-xxxx")]
        public string? Phone { get; set; }

        public string? Password {  get; set; }

        [Compare("Password", ErrorMessage = "{0} and {1} does not match")]//comapares confirm password to password
        public string? ConfirmPassword { get; set; }

        [Range(0,999.99, ErrorMessage = "{0} should be between {1} and {2}")]
        public double? Price { get; set; }

        //[MinimumYearValidator(1500, ErrorMessage = "year should be greater than {0}")]

        [MinimumYearValidator(1500)]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }

        [DateRangeValidator("FromDate", ErrorMessage = "{0} should be older than the {1}")]
        public DateTime? ToDate { get; set; }

        // [BindNever] // unbinds the Age from receiving values through the modelbinding
        public int? Age { get; set; }

        public override string ToString()
        {
            return $"Person Object - Person Name: {Name}, Email: {Email}, Phone: {Phone}, Price:{Price}";

        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(DateOfBirth.HasValue == false && Age.HasValue == false)
            {
                yield return new ValidationResult("either of data of birth or age should be supplied", 
                    new[] { nameof(Age)});
            }
        }
    }
}
