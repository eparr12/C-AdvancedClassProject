using System.Text.RegularExpressions;

namespace GlobalConsultingUI.Validation
{
    public static class InputValidators
    {
        static readonly string _letters = "^[A-Za-z ]*$";
        static readonly string _numbers = "^[0-9]*$";
        static readonly string _lettersNumbers = "^[A-Za-z0-9 ]*$";
        static readonly string _phoneNumber = "^[0-9]{3}-[0-9]{4}$";
        static readonly string _password = "^[<>']$";

        public static bool LetterValidator(string text)
        {
            if((string.IsNullOrWhiteSpace(text)) || (!Regex.Match(text, _letters).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool LetterNumberValidator(string text)
        {
            if ((string.IsNullOrWhiteSpace(text)) || (!Regex.Match(text, _lettersNumbers).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NumberValidator(string text)
        {
            if ((string.IsNullOrWhiteSpace(text)) || (!Regex.Match(text, _numbers).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PhoneNumberValidator(string text)
        {
            if ((string.IsNullOrWhiteSpace(text)) || (!Regex.Match(text, _phoneNumber).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PasswordValidator(string text)
        {
            if ((string.IsNullOrWhiteSpace(text)) || (Regex.Match(text, _password).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
