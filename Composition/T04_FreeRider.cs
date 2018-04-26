using NUnit.Framework;

namespace Composition
{
    [TestFixture]
    public class T04_FreeRider : InputTransformatorBaseFixture //Unrelated assertations
    {
        [Test]
        public void Transform_Input_ReturnsTransformedInput()
        {
            //Act
            var result = _inputTransformator.Transform(_input);

            //Assert
            Assert.AreEqual("transformed @ input string", result);
            Assert.AreEqual("transformed @ input string", _inputTransformator.LastTransformedInput);
        }
    }
}
