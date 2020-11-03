using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPoblemPatterns
{
    /// <summary>
    /// It Consist a Pattern 
    /// </summary>
    class Pattern
    {
        public const string USER_NAME = "^[A-Z][a-z]{2,}[ ][A-Z][a-z]{2,}$";
        public const string EMAIL_ID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$";
        public const string MOBILE_NUMBER = "^[+][1-9][0-9]{0,2}[-][1-9][0-9]{9}$";
        public const string PASSWORD = "^(.{8,}|[^0-9]*|[^!#@$%^&*()<>:@?{}]*|[^A-Z])$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="fname">The fname.</param>
        public bool ValidateFullName(string fullName)
        {
            /// It will check Full Name and, It returns ture or false
            bool fullNameCheck = Regex.IsMatch(fullName, USER_NAME);
            if (fullNameCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        public bool ValidateEmail(string eMail)
        {
            /// It Checks the Email and, It returns ture or false
            bool emailCheck = Regex.IsMatch(eMail, EMAIL_ID);
            if (emailCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        public bool ValidatePhoneNo(string mobileNumber)
        {
            /// It Checks the Mobile Number and, It returns ture or false
            bool numberCheck = Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
            if (numberCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        public bool ValidatePassword(string password)
        {
            /// It Checks the Password and, It returns ture or false
            bool passwordCheck = Regex.IsMatch(password, PASSWORD);
            if (passwordCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}