using NUnit.Framework;
using Overspecification.TestClasses;

namespace Overspecification
{
    [TestFixture]
    public class T01_UglyMirror : InputTransformatorBaseFixture //Test mirroring code
    {
        [Test]
        public void Transform_Input_ReturnsTransformedInput()
        {
            //Act
            var result = _inputTransformator.Transform(_input);

            //Assert
            Assert.AreEqual($"{InputTransformator.Prefix} @ {_input}", result);

            //Better
            //Assert.AreEqual("transformed @ input string", result);
        }
    }
}
