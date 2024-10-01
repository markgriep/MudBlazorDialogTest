

using System.ComponentModel.DataAnnotations;

namespace MudBlazorWebApp2
{
    public class AllowedValuesAttribute : ValidationAttribute
    {
        private readonly string[] _allowedValues;

        public AllowedValuesAttribute(string[] allowedValues)
        {
            _allowedValues = allowedValues;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && _allowedValues.Contains(value.ToString()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"The field {validationContext.DisplayName} only accepts the values: {string.Join(", ", _allowedValues)}.");
        }
    }


}
