using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTest;

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
    }
}
