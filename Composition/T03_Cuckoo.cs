using NUnit.Framework;
using Composition.TestClasses;

namespace Composition
{
    [TestFixture]
    public class T03_Cuckoo : InputTransformatorBaseFixture //Test unrelated classes
    {
        [Test]
        public void Handle_Input_ReturnsHandledInput()
        {
            //Arrange
            var input = "some data";
            var inputHandler = new InputHandler();

            //Act
            var result = inputHandler.Handle(input);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
