using System.Collections.Generic;
using VirtualAtm.Domain;

namespace VirtualAtm.Services
{
    public interface IAccountService
    {
        Account GetAccount(string cardNumber, string pin);
        Account VerifyPinAndGetAccount(string cardNumber, string pin);
        List<Account> GetAllAccounts();
    }
}