namespace Composition.TestClasses
{
    public class BankAccountV3
    {
        private IBalanceRepository _repository;
        public BankAccountV3(int accountId, IBalanceRepository repository)
        {
            AccountId = accountId;
            _repository = repository;
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
