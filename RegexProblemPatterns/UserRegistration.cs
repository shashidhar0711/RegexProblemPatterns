using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblemPatterns
{
    public class UserRegistration
    {
        /// Consonants
        public const string FULL_NAME = "^[A-Z][a-z]{2,}[ ][A-Z][a-z]{2,}$";
        public const string EMAIL_ID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$";
        public const string MOBILE_NUMBER = "^[+][1-9][0-9]{0,2}[ ][1-9][0-9]{9}$";
        public const string PASSWORD = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*-+]{1}).{8,}$";

        /// <summary>
        /// Validates the full name.
        /// </summary>
        /// <param name="fullName">The full name.</param>
        /// <returns></returns>
        public bool ValidateFullName(string fullName)
        {
            try
            {
                return Regex.IsMatch(fullName, FULL_NAME);
            }

            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FULLNAME, "Invalid Name Format");
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="eMail">The e mail.</param>
        /// <returns></returns>
        public bool ValidateEmail(string eMail)
        {
            try
            {
                return Regex.IsMatch(eMail, EMAIL_ID);
            }

            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email Format");
            }

        }

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            try
            {
                return Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
            }

            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONENUMBER, "Invalid Number Format");
            }
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            try
            {
                return Regex.IsMatch(password, PASSWORD);
            }

            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password Format");
            }
        }
    }
}
