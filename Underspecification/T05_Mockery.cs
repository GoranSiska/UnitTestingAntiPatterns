using NSubstitute;
using NUnit.Framework;
using Underspecification.TestClasses;

namespace Underspecification
{
    [TestFixture]
    public class T05_Mockery //Test mocking framework
    {
        [Test]
        public void Validate_InvalidInput_ThrowsArgumentException()
        {
            //Arrange
            var validInput = 100;
            var inputValidator = Substitute.For<IInputValidator>();
            inputValidator
                .Validate(validInput)
                .Returns(validInput);

            //Act
            var result = inputValidator.Validate(validInput);

            //Assert
            Assert.AreEqual(validInput, result);

            //Best to remove such test
        }
    }
}
