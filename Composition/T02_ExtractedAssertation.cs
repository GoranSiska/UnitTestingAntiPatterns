using NUnit.Framework;

namespace Composition
{
    [TestFixture]
    public class T02_ExtractedAssertation : InputTransformatorBaseFixture //Atomicity and visibility
    {
        [Test]
        public void Transform_Input_ReturnsTransformedInput()
        {
            //Act
            var result = _inputTransformator.Transform(_input);

            //Assert
            TransformationAssert.IsTransformed(result);
        }
    }

    public static class TransformationAssert
    {
        public static void IsTransformed(string transformedInput)
        {
            StringAssert.StartsWith("transformed @", transformedInput);
        }
    }
}
