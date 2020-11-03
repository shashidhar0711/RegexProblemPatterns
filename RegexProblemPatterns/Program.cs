using System;

namespace RegexProblemPatterns
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
            UserRegistration userRegistration = new UserRegistration();

            /// Taking Full Name from Console to Validate
            Console.WriteLine("Enter the Full Name :");
            string fullName = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateFullName(fullName));

            /// Taking Email from Console to Validate
            Console.WriteLine("Enter the Email :");
            string eMail = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateEmail(eMail));

            /// Taking Phone Number from Console to Validate
            Console.WriteLine("Enter the Phone Number :");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateMobileNumber(mobileNumber));

            /// Taking Password from Console to Validate
            Console.WriteLine("Enter the Password :");
            string password = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidatePassword(password));
        }
    }
}
