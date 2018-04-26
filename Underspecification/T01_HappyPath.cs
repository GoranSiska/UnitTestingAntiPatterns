using NUnit.Framework;
using Underspecification.TestClasses;

namespace Underspecification
{
    [TestFixture]
    public class T01_HappyPath //Test best case scenario only
    {
        [Test]
        public void Validate_InvalidInput_ThrowsArgumentException()
        {
            //Arrange
            var validInput = 100;
            var inputValidator = new InputValidator();

            //Act
            var result = inputValidator.Validate(validInput);

            //Assert
            Assert.AreEqual(validInput, result);

            //Best to write additional tests
        }
    }
}
