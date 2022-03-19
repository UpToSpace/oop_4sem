using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace laba2
{
    class NameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (Regex.IsMatch(value as string, @"^[a-zA-Z\s]*$"))
            {
                return true;
            }
            else
            {
                ErrorMessage = "only letters available";
            }
            return false;
        }
    }
}
