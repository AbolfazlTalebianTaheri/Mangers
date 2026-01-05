
using Manger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnager
{
    public class Teacher : Person
    {
        [Required]
        public string PhonNumber { get; set; }
        [Required]
        public string Locatioan { get; set; }
        public Field_Of_Study Study { get; set; }
        public static OperionResult IsValidinput(string firstName, string lastName, string location, string phoneNumber, string nationalCode)
        {
            if (string.IsNullOrEmpty(firstName))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = Messages.FirstName
                };
            else if (string.IsNullOrEmpty(lastName))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = Messages.LastName
                };
            else if (string.IsNullOrEmpty(location))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = Messages.Location
                };
            else if (string.IsNullOrEmpty(nationalCode))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = Messages.NationalDode
                };
            else if (string.IsNullOrEmpty(phoneNumber))
                return new OperionResult
                {
                    IsSuccess = false,
                    Message = Messages.PhoneNumber
                };
            return new OperionResult
            {
                IsSuccess = true,
                Message = Messages.Success
            };
        }
    }
}
