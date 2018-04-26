using System;

namespace Misspecification.TestClasses
{
    public class TestFailingBalanceRepository : IBalanceRepository
    {
        public int QueryBalance(int accountId)
        {
            throw new Exception("Database not available!");
        }

        public void StoreBalance(int accountId, int amount)
        {
            throw new Exception("Database not available!");
        }
    }
}
