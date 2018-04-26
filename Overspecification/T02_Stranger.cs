using NUnit.Framework;
using Overspecification.TestClasses;

namespace Overspecification
{
    [TestFixture]
    public class T02_Stranger : InputTransformatorBaseFixture //Test two units
    {
        [Test]
        public void Handle_TransformedInput_ReturnsHandledTransformedInput()
        {
            //Arrange
            var inputHandler = new InputHandler();

            //Act
            var result = inputHandler.Handle(_inputTransformator.Transform(_input));

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
