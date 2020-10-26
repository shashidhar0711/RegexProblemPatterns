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
        public static string FIRST_NAME = "^[A-Z][a-z]{2,}$";
        public static string LAST_NAME = "^[A-Z][a-z]{2,}$";
        public static string EMAIL_ID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$";
        public static string MOBILE_NUMBER = "^[+][1-9][0-9]{0,2}[-][1-9][0-9]{9}$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="fname">The fname.</param>
        public void ValidateFirstName(string fname)
        {
            bool firstNameCheck = Regex.IsMatch(fname, FIRST_NAME);
            if(firstNameCheck)
            {
                Console.WriteLine(fname + " :is Valid");
            }
            else
            {
                Console.WriteLine(fname + " :is Not Valid");
            }
        }

        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lname">The lname.</param>
         public void ValidateLastName(string lname)
        {
            /// It Checks the Last Name and, Prints valid or not
            bool lastNameCheck = Regex.IsMatch(lname, LAST_NAME);
            if(lastNameCheck)
            {
                Console.WriteLine(lname + " :is Valid");
            }
            else
            {
                Console.WriteLine(lname + " :is Not Valid");
            }

        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        public void ValidateEmail(string email)
        {
            /// It Checks the Email and, Prints valid or not
            bool emailCheck = Regex.IsMatch(email, EMAIL_ID);
            if(emailCheck)
            {
                Console.WriteLine(email + " :is Valid");
            }
            else
            {
                Console.WriteLine(email + " :is Not Valid");
            }
        }

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        public void ValidatePhoneNo(string mobileNumber)
        {
            /// It Checks the First Name and, Prints valid or not
            bool numberCheck =  Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
            if(numberCheck)
            {
                Console.WriteLine(mobileNumber + " :is Valid");
            }
            else
            {
                Console.WriteLine(mobileNumber + " :is Not Valid");
            }
        }
    }
}