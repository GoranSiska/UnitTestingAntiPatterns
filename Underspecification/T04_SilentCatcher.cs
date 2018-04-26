using NUnit.Framework;
using System;
using Underspecification.TestClasses;

namespace Underspecification
{
    [TestFixture]
    public class T04_SilentCatcher //Underspecified assert
    {
        [Test]
        public void Validate_InvalidInput_ThrowsArgumentException()
        {
            //Arrange
            var invalidInput = -100;
            var inputValidator = new InputValidator();

            //Act
            TestDelegate testDelegate = () => inputValidator.Validate(invalidInput);

            //Assert
            Assert.That(testDelegate, Throws.Exception);

            //Better Assert
            //Assert.That(testDelegate, Throws.TypeOf<ArgumentOutOfRangeException>());

            //Best Assert
            //var ex = Assert.Throws<ArgumentOutOfRangeException>(testDelegate);
            //Assert.AreEqual("input", ex.ParamName);
        }
    }
}
