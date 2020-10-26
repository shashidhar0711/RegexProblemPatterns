﻿/*
 *  C# CODING STANDARDS - LINE SPACE
 *  NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\sasic\source\repos\RegexProblem_C\bin\Debug\netcoreapp3.1\RegexProblemPatterns_C.exe
 *  Execution:    RegexProblemPatterns_C.exe
 *  
 *  Purpose: Validate the User Registration By Using Regular Expression
 *
 *  @author  Shashidhar C
 *  @version 1.0
 *  @since   18-10-2020
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace RegexPoblemPatterns
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Creating a Reference for Pattern Class
            Pattern pattern = new Pattern();

            /// Taking First Name from Console to Validate
            Console.WriteLine("Enter the First Name :");
            string fname = Console.ReadLine();
            pattern.ValidateFirstName(fname);

            /// Taking Last Name from Console to Validate
            Console.WriteLine("Enter the Last Name :");
            string lname = Console.ReadLine();
            pattern.ValidateLastName(lname);

            /// Taking Email from Console to Validate
            Console.WriteLine("Enter the Email :");
            string email = Console.ReadLine();
            pattern.ValidateEmail(email);

            /// Taking Phone Number from Console to Validate
            Console.WriteLine("Enter the Phone Number :");
            string mobileNumber = Console.ReadLine();
            pattern.ValidatePhoneNo(mobileNumber);

        }
    }
}