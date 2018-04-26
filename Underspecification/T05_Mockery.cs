using Moq;
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
            var inputValidatorMock = new Mock<IInputValidator>();
            inputValidatorMock
                .Setup(iv => iv.Validate(It.IsAny<int>()))
                .Returns(validInput);
            var inputValidator = inputValidatorMock.Object;

            //Act
            var result = inputValidator.Validate(validInput);

            //Assert
            Assert.AreEqual(validInput, result);

            //Best to remove such test
        }
    }
}
