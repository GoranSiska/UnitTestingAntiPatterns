using Ninject;

namespace Misspecification.TestClasses
{
    public class BankAccountV2
    {
        private IBalanceRepository _repository;
        public BankAccountV2(int accountId)
        {
            AccountId = accountId;
            _repository = StaticKernel.Instance.Get<IBalanceRepository>();
        }

        public int AccountId { get; private set; }

        public int DepositAndReturnBalance(int amount)
        {
            var currentBalance = GetBalance();
            var newBalance = currentBalance + amount;
            SetBalance(newBalance);

            return newBalance;
        }

        public int GetBalance()
        {
            return _repository.QueryBalance(AccountId);
        }

        public void SetBalance(int amount)
        {
            _repository.StoreBalance(AccountId, amount);
        }
    }
}
