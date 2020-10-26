/*
 *  C# CODING STANDARDS - LINE SPACE
 *  NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\sasic\source\repos\RegexProblem_C\bin\Debug\netcoreapp3.1\RegexProblemPatterns_C.exe
 *  Execution:    RegexProblemPatterns_C.exe
 *  
 *  Purpose: Validate the First Name By Using Regular Expression
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
            Console.WriteLine(pattern.ValidateMethod("Sasi"));
        }
    }
}