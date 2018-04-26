using Misspecification.TestClasses;
using NUnit.Framework;

namespace Misspecification
{
    [TestFixture]
    public class T03_Volkswagen //Works differently when testing
    {
        [Test]
        public void DepositAndReturnBalance_Input_ReturnsDepositedBalance()
        {
            //Arrange
            var bankAccount = new BankAccount(123);

            //Act
            var result = bankAccount.DepositAndReturnBalance(12);

            //Assert
            Assert.AreEqual(12, result);
        }
    }
}
