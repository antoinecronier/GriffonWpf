using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Entities.Validators
{
    public class NameValidator : ValidationAttribute
    {
        private int min = 6;
        private int max = 24;

        public NameValidator()
        {
            this.ErrorMessage = "Name is not validated :";
        }

        public NameValidator(int min, int max) : this()
        {
            this.min = min;
            this.max = max;
            if (min > max)
            {
                throw new Exception("min cannot be higher than max");
            }
        }

        public NameValidator(String errorMessage, int min, int max) : this(min, max)
        {
            this.ErrorMessage = errorMessage;
        }

        public override bool IsValid(object value)
        {
            bool result = false;
            if (value != null)
            {
                result = true;

                String testing = value.ToString();
                if (testing.Length < min || testing.Length > max)
                {
                    this.ErrorMessage += "\nName Length not between [" + min + "-" + max + "]";
                    result = false;
                }

            }
            return result;
        }
    }
}
