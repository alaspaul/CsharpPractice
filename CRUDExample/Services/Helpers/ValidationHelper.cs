﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Services.Helpers
{
    public class ValidationHelper
    {
        internal static void ModelValidation(object ojb)
        {
            ValidationContext validationContext = new ValidationContext(ojb);

            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool isValid =
                Validator.TryValidateObject(ojb, validationContext, validationResults, true);

            if (!isValid)
            {
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);
            }
        }
    }
}
