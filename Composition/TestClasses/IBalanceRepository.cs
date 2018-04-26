using System;

namespace Composition.TestClasses
{
    public interface IBalanceRepository
    {
        int QueryBalance(int accountId);
        void StoreBalance(int accountId, int amount);
    }
}
