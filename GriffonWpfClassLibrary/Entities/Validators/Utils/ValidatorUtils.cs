using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Entities.Validators.Utils
{
    public static class ValidatorUtils
    {
        public static bool Validate(object item, out List<ValidationResult> validationResults)
        {
            var context = new ValidationContext(item, serviceProvider: null, items: null);
            validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(item, context, validationResults, true);

            return isValid;
        }

        public static bool PropertyErrorAction(String propertyName, object item, Action<String> action)
        {
            bool result;
            List<System.ComponentModel.DataAnnotations.ValidationResult> validationResults;
            if (result = !ValidatorUtils.Validate(item, out validationResults))
            {
                foreach (var validationResult in validationResults)
                {
                    if (validationResult.MemberNames.Contains(propertyName))
                    {
                        action.Invoke(validationResult.ErrorMessage);
                    }
                }
            }

            return !result;
        }
    }
}
