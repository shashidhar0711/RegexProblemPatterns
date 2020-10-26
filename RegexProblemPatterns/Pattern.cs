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

        /// <summary>
        /// Validates the method.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <returns></returns>
        public bool ValidateMethod(string fname)
        {
            /// It returns a Boolean Value ie true or false
            return Regex.IsMatch(fname, FIRST_NAME);
        }
    }
}