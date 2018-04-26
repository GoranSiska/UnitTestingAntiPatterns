using NUnit.Framework;
using Composition.TestClasses;

namespace Composition
{
    [TestFixture]
    public class InputTransformatorBaseFixture
    {
        protected string _input;
        protected IInputTransformator _inputTransformator;

        [SetUp]
        public void SetUp()
        {
            _input = "input string";
            _inputTransformator = new InputTransformator();
        }
    }
}
