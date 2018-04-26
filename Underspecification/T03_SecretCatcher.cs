using NUnit.Framework;
using Underspecification.TestClasses;

namespace Underspecification
{
    [TestFixture]
    public class T03_SecretCatcher //Implied assert
    {
        [Test]
        public void Validate_ValidInput_DoesNotThrowException()
        {
            //Arrange
            var validInput = 100;
            var inputValidator = new InputValidator();

            //Act
            //inputValidator.Validate(input);
            TestDelegate testDelegate = () => inputValidator.Validate(validInput);

            //Implied Assert

            //Better Assert
            //Assert.That(testDelegate, Throws.Nothing);

            //Best to write meaningful test
        }
    }
}
