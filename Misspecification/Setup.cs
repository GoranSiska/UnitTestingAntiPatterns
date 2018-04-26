using NUnit.Framework;

namespace Misspecification
{
    [SetUpFixture]
    public class Setup
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            AppContext.IsUnderTesting = true;
        }
    }
}
