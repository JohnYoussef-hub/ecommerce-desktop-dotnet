using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_commerce.Global_Classes
{
    public class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }


        public static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
        }

        public static bool IsValidNationalNumber(string nationalNo)
        {
            return Regex.IsMatch(nationalNo, @"^[A-Za-z]*\d{2,15}$");
        }


        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length >= 2;
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        public static bool IsValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address) && address.Length >= 5;
        }

        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 5;
        }

        public static bool IsValidUserName(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 3 && 
                (!Ecommerce_BusinessLayer.clsUser.IsUserExistsByUserName(username));
        }

        public static bool IsValidDescription(string description)
        {
            // Ensure the description is not null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(description))
            {
                return false;
            }

            // Ensure the description length is within acceptable limits (e.g., 5 to 500 characters)
            if (description.Length < 5 || description.Length > 500)
            {
                return false;
            }

            // Optionally, ensure the description does not contain invalid characters
            // (e.g., no special characters like <, >, or script tags)
            if (description.Contains("<") || description.Contains(">") || description.Contains("script"))
            {
                return false;
            }

            return true;
        }
    }

}
