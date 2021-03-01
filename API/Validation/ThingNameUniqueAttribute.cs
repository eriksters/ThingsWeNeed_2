using System.ComponentModel.DataAnnotations;
using ThingsWeNeed.DataLogic;
using ThingsWeNeed.DataLogic.Repos;

namespace ThingsWeNeed.API.Validation
{
    public class ThingNameUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext)
        {
            var repo = (ThingRepo) validationContext.GetService(typeof(IThingRepo));

            if (!repo.ThingNameIsValid((string) value))
            {
                return new ValidationResult(GetErrorMessage((string) value));
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage(string name)
        {
            return $"{name} is already a thing.";
        }
    }
}