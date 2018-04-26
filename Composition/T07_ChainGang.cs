using Composition.TestClasses;
using NUnit.Framework;

namespace Composition
{
    [TestFixture]
    public class T07_ChainGang //Works in specific order
    {
        private IBalanceRepository _repository;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _repository = new TestBalanceRepository();
        }

        [Test]
        public void OrderedTests()
        {
            DepositAndReturnBalance_Input_ReturnsDepositedBalance();
            DepositAndReturnBalance_Input_ReturnsAccruedBalance();
        }

        [Test, Order(1)]
        [Ignore("Must be run in order")]
        public void DepositAndReturnBalance_Input_ReturnsDepositedBalance()
        {
            //Arrange
            var bankAccount = new BankAccountV3(123, _repository);

            //Act
            var result = bankAccount.DepositAndReturnBalance(12);

            //Assert
            Assert.AreEqual(12, result);
        }

        [Test, Order(2)]
        [Ignore("Must be run in order")]
        public void DepositAndReturnBalance_Input_ReturnsAccruedBalance()
        {
            //Arrange
            var bankAccount = new BankAccountV3(123, _repository);

            //Act
            var result = bankAccount.DepositAndReturnBalance(12);

            //Assert
            Assert.AreEqual(24, result);
        }
    }
}
