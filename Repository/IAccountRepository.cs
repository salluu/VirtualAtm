using System.Linq;
using VirtualAtm.Domain;

namespace VirtualAtm.Repository
{
    public interface IAccountRepository
    {
        IQueryable<Account> GetAccounts();
    }
}