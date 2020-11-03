using System;
using System.Collections.Generic;
using System.Text;

namespace RegexProblemPatterns
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE, EMPTY_MESSAGE, EMPTY_NULL,
            NULL_MESSAGE, INVALID_FULLNAME, INVALID_PHONENUMBER, INVALID_EMAIL, INVALID_PASSWORD
        }

        /// Creating type Variable of type ExceptionType
        private readonly ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
