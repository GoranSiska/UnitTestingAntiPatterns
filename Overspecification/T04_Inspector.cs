using NUnit.Framework;
using Overspecification.TestClasses;
using System.Reflection;

namespace Overspecification
{
    [TestFixture]
    public class T04_Inspector : InputTransformatorBaseFixture //Test implementation
    {
        [Test]
        public void Handle_TransformedInput_ReturnsHandledTransformedInput()
        {
            //Arrange
            var inputHandler = new InputHandler();
            var calcualtionMethod = typeof(InputHandler).GetMethod("Calculate", BindingFlags.NonPublic | BindingFlags.Instance);
            
            //Act
            var result = calcualtionMethod.Invoke(inputHandler, new object[] { 4 });

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
