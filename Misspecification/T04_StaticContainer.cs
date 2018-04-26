using Misspecification.TestClasses;
using NUnit.Framework;

namespace Misspecification
{
    [TestFixture]
    public class T04_StaticContainer //May fail with no change
    {
        [Test]
        public void DepositAndReturnBalance_Input_ReturnsDepositedBalance()
        {
            //for (var i = 0; i < 100; i++)
            //{
                //Arrange
                StaticKernel.Instance.Bind<IBalanceRepository>().To<TestBalanceRepository>();
                var bankAccount = new BankAccountV2(123);
                //var bankAccount = new BankAccountV3(123, new TestBalanceRepository());

                //Act
                var result = bankAccount.DepositAndReturnBalance(12);

                //Assert
                Assert.AreEqual(12, result);
            //}
        }

        [Test]
        public void DepositAndReturnBalance_Input_WhenDatabaseNotAvailable_ThrowsException()
        {
            //for (var i = 0; i < 100; i++)
            //{
                //Arrange
                StaticKernel.Instance.Bind<IBalanceRepository>().To<TestFailingBalanceRepository>();
                var bankAccount = new BankAccountV2(123);
                //var bankAccount = new BankAccountV3(123, new TestFailBalanceRepository());

                //Act
                TestDelegate testDelegate = () => bankAccount.DepositAndReturnBalance(12);

                //Assert
                Assert.That(testDelegate, Throws.Exception);
            //}
        }
    }
}
