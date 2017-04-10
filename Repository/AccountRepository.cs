using System.Collections.Generic;
using System.Linq;
using VirtualAtm.Domain;

namespace VirtualAtm.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public IQueryable<Account> GetAccounts()
        {
            return new List<Account>()
            {
                new Account() {AccountNumber = "56987456", Pin = "0001", Balance = 500, CardNumber = "0000111122223333"},
                new Account() {AccountNumber = "56987457", Pin = "0002", Balance = 50, CardNumber = "0000111122223334"}
            }.AsQueryable();
        }
    }
}