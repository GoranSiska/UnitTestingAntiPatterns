using NUnit.Framework;
using Composition.TestClasses;

namespace Composition
{
    [TestFixture]
    public class T01_ExtractedFixture //Atomicity and visibility
    {
        protected BankAccountV3 _bankAccount;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var repository = new TestBalanceRepository();
            _bankAccount = new BankAccountV3(123, repository);
            repository.StoreBalance(_bankAccount.AccountId, 10);
        }
    }

    [TestFixture]
    public class DepositAndReturnBalanceTests : T01_ExtractedFixture
    {
        [Test]
        public void DepositAndReturnBalance_Input_ReturnsDepositedBalance()
        {
            //Act
            var result = _bankAccount.DepositAndReturnBalance(12);

            //Assert
            Assert.AreEqual(22, result);
        }
    }
}
