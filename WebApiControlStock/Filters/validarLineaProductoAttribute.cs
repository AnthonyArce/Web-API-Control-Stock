using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Filters
{
    public class validarLineaProductoAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().Equals("H") || value.ToString().Equals("S"))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("La linea solo puede ser H o S");
        }
    }
}
