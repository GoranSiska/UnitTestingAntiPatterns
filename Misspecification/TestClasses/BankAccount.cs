namespace Misspecification.TestClasses
{
    public class BankAccount
    {
        private int _balance;
        private IBalanceRepository _repository;
        public BankAccount(int accountId)
        {
            AccountId = accountId;
        }

        public int AccountId { get; private set; }

        public int DepositAndReturnBalance(int amount)
        {
            if (AppContext.IsUnderTesting)
            {
                _balance += amount;

                return _balance;
            }
            else
            {
                var currentBalance = GetBalance();
                var newBalance = currentBalance + amount;
                SetBalance(newBalance);

                return newBalance;
            }
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
