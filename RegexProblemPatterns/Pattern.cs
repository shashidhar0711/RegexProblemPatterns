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

        /// <summary>
        /// Validates the method.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <returns></returns>
        public bool ValidateFirstName(string fname)
        {
            /// It returns a Boolean Value ie true or false
            return Regex.IsMatch(fname, FIRST_NAME);
        }

        public bool ValidateLastName(string lname)
        {
            /// It returns a Boolean Value ie true or false
            return Regex.IsMatch(lname, LAST_NAME);
        }

        public bool ValidateEmail(string email)
        {
            /// It returns a Boolean Value ie true or false
            return Regex.IsMatch(email, EMAIL_ID);
        }
    }
}