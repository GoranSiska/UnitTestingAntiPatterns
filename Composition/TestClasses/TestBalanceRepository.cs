using System.Collections.Concurrent;

namespace Composition.TestClasses
{
    public class TestBalanceRepository : IBalanceRepository
    {
        private static ConcurrentDictionary<int, int> _repository;
        static TestBalanceRepository()
        {
            _repository = new ConcurrentDictionary<int, int>();
        }

        public int QueryBalance(int accountId)
        {
            return _repository.GetOrAdd(accountId, 0);
        }

        public void StoreBalance(int accountId, int amount)
        {
            _repository[accountId] = amount;
        }
    }
}
