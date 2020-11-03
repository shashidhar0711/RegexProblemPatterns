/*
 * 
 *  C# CODING STANDARDS - LINE SPACE
 *  NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\sasic\source\repos\RegexProblemPatterns_C\bin\Debug\netcoreapp3.1\RegexProblemPatterns_C.exe
 *  Execution:    RegexProblemPatterns_C.exe
 *  
 *  Purpose: Validating User Registration Using Lamda Function
 *
 *  @author  Shashidhar C
 *  @version 1.0
 *  @since   26-10-2020
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
namespace RegexPoblemPatterns
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            /// Creating a Reference for Pattern Class
            ValidateUsingLamda validateUsingLamda = new ValidateUsingLamda();

            /// Taking Full Name from Console to Validate
            Console.WriteLine("Enter the Full Name :");
            string fullName = Console.ReadLine();
            Console.WriteLine(validateUsingLamda.ValidateFullName(fullName));

            /// Taking Email from Console to Validate
            Console.WriteLine("Enter the Email :");
            string eMail = Console.ReadLine();
            Console.WriteLine(validateUsingLamda.ValidateEmail(eMail));

            /// Taking Phone Number from Console to Validate
            Console.WriteLine("Enter the Phone Number :");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(validateUsingLamda.ValidateMobileNumber(mobileNumber));


            /// Taking Password from Console to Validate
            Console.WriteLine("Enter the Password :");
            string password = Console.ReadLine();
            Console.WriteLine(validateUsingLamda.ValidatePassword(password));
        }
    }
    
}

