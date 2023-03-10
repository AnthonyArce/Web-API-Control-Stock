using System.ComponentModel.DataAnnotations;
using System;

namespace WebApiControlStock.Filters
{
    public class PrecioAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ( ( value != null || !string.IsNullOrEmpty(value.ToString()) ) && Convert.ToDecimal(value) > 0)
            {
                return ValidationResult.Success;
            }
           
            return new ValidationResult("Precio debe ser mayor a cero!");


        }

    }
}
