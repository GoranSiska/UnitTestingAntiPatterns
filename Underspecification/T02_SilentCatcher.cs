using NUnit.Framework;
using System;
using Underspecification.TestClasses;

namespace Underspecification
{
    [TestFixture]
    public class T02_SilentCatcher //Underspecified assert
    {
        [Test]
        public void Method_GivenInvalidInput_ThrowsArgumentException()
        {
            //Arrange
            var input = -100;
            var inputValidator = new InputValidator();

            //Act
            TestDelegate testDelegate = () => inputValidator.Validate(input);

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
