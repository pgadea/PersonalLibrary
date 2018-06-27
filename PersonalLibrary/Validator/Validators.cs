using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace PersonalLibrary.Validator
{
    public class Validators
    {
        // TODO: ValidateName method = should have at least 2 letters, no numbers, and only dash, return true or false
        // TODO: ValidateEmail method
        // TODO: ValidatePhoneNumber method
        // TODO: ValidateZipCode method
        // TODO: Add more validatorAdd more validators
        // TODO: Unit Tests for methods

        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            return name.Length >= 2 && !name.Any(char.IsDigit) && Regex.IsMatch(name, "[a-zA-Z/'/-]+");
        }

        public bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && new EmailAddressAttribute().IsValid(email);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && new PhoneAttribute().IsValid(phoneNumber) 
                && phoneNumber.Length == 10;
        }

        public bool IsZipCodeValid(string zipCode)
        {
            return !string.IsNullOrWhiteSpace(zipCode) && Regex.IsMatch(zipCode, @"^\d{5}$");
        }
    }
}
