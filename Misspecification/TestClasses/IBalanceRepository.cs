using System;

namespace Misspecification.TestClasses
{
    public interface IBalanceRepository
    {
        int QueryBalance(int accountId);
        void StoreBalance(int accountId, int amount);
    }
}
