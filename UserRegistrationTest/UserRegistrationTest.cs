using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTest;
using RegexProblemPatterns;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistrationTest
    {
        private readonly RegexProblemPatterns.UserRegistration userRegistration = new RegexProblemPatterns.UserRegistration();

        /// <summary>
        /// Validate the name It returns boolean value.
        /// </summary>
        [TestMethod]
        [DataRow("Shashidhar", false)]
        [DataRow("Shashi Dhar", true)]
        public void ValidatingGivenName_ShouldReturnBooleanValue()
        {
            /// Arrange
            string fullName = "Shashi Dhar";

            /// Act
            bool result = userRegistration.ValidateFullName(fullName);

            /// Assert
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Validate the Email id It returns a boolean value
        /// </summary>
        [TestMethod]
        [DataRow("Shashidhar.sasic@gmail.com", true)]
        [DataRow(".Shashidhar.sasic@gmail.com", false)]
        public void ValidatingGivenEmail_ShouldReturnBooleanValue()
        {
            /// Arrange
            string eMail = "Shashidhar.sasic@gmail.com";

            /// Act
            bool result = userRegistration.ValidateEmail(eMail);

            /// Assert
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Validate the Number It returns a boolean value
        /// </summary>
        [TestMethod]
        [DataRow("+91 8073112156", true)]
        [DataRow("+91-8073112156", false)]
        public void ValidatingGivenMobileNumber_ShouldReturnBooleanValue()
        {

            /// Arrange
            string mobileNumber = "+91 8073112156";

            /// Act
            bool result = userRegistration.ValidateMobileNumber(mobileNumber);

            /// Assert
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Validate the passsword It returns a boolean value
        /// </summary>
        [TestMethod]
        [DataRow("Shashi@123", true)]
        [DataRow("Shashi", false)]
        public void ValidatingGivenPassword_ShouldReturnBooleanValue()
        {
            /// Arrange
            string password = "Shashi@123";

            /// Act
            bool result = userRegistration.ValidatePassword(password);

            /// Assert
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Giving Invalid UserName to Validate and It  should throw the exception ie Invalid Name Format
        /// Here it is Custom Exception to Handle
        /// </summary>
        [TestMethod]
        [DataRow("shashidhar sasic", false)]
        [DataRow("shashidhar", false)]
        [DataRow("shashidhar0711", false)]
        [DataRow("Shashidhar.sasic", false)]
        public void ValidatingInValidFullName_ItShouldThrowException_InvalidNameFormat()
        {
            try
            {
                /// Arrange
                string fullName = "shashidhar sasic";

                /// Act
                bool result = userRegistration.ValidateFullName(fullName);
            }
            catch (UserRegistrationCustomException Exception)
            {
                /// Assert
                Assert.AreEqual("Invalid Name Format", Exception.Message);
            }
        }

        /// <summary>
        /// Giving Invalid Gmail ID to Validate and It should throw the  exception ie Invalid Email Format
        /// </summary>
        [TestMethod]
        [DataRow("Shashidhar@gmail.com.com", false)]
        [DataRow("Shashidhar@gmail.com.co.in", false)]
        [DataRow(".100shashidhar@yahoo.in", false)]

        public void ValidatingInValidGmail_ItShouldThrowException_InvalidEmailFormat()
        {
            try
            {
                /// Arrange
                string eMail = "Shashidhar.sasic@gmail.com.com";

                /// Act
                bool result = userRegistration.ValidateFullName(eMail);
            }
            catch (UserRegistrationCustomException Exception)
            {
                /// Assert
                Assert.AreEqual("Invalid Email Format", Exception.Message);
            }
        }

        /// <summary>
        /// Giving Invalid Mobile Number to Validate to should throw the exception ie Invalid Number Format
        /// </summary>
        [TestMethod]
        [DataRow("09 8073112156", false)]
        [DataRow("+09-8073112156", false)]
        public void ValidatingInValidPhoneNumber_ItShouldThrowException_InvalidNumberFormat()
        {
            try
            {
                /// Arrange
                string mobileNumber = "09 8073112156";

                /// Act
                bool result = userRegistration.ValidateFullName(mobileNumber);
            }
            catch (UserRegistrationCustomException Exception)
            {
                /// Assert
                Assert.AreEqual("Invalid Number Format", Exception.Message);
            }
        }

        /// <summary>
        /// Giving Invalid Password to Validate and it should throw the exception ie Invalid Password Format
        /// </summary>
        [TestMethod]
        [DataRow("Shashi", false)]
        [DataRow("/*123456", false)]
        public void ValidatingInValidPassword_ItShouldThrowException_InvalidPasswordFormat()
        {
            try
            {
                /// Arrange
                string password = "Shashi";

                /// Act
                bool result = userRegistration.ValidateFullName(password);
            }
            catch (UserRegistrationCustomException Exception)
            {
                /// Assert
                Assert.AreEqual("Invalid Password Format", Exception.Message);
            }
        }
    }
}
