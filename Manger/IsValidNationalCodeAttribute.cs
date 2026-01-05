using Mnager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger
{
    public class IsValidNationalCodeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == "")
            {
                ErrorMessage = Messages.NationalDode;
                return false;
            }
            var st = (string)value;
            var isNationalCode = Person.IsNationalCode(st);
            if (!isNationalCode)
            {
                ErrorMessage = "کد ملی را درست کنید";
                return false;
            }
            return true;
        }
    }
}
