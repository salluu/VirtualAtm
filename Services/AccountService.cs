using System.Collections.Generic;
using System.Linq;
using VirtualAtm.Domain;
using VirtualAtm.Exceptions;
using VirtualAtm.Repository;

namespace VirtualAtm.Services
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

        }

        public List<Account> GetAllAccounts()
        {
            return _accountRepository.GetAccounts().ToList();
        }

        public Account GetAccount(string cardNumber, string pin)
        {
            return _accountRepository.GetAccounts().FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);
        }

        public Account VerifyPinAndGetAccount(string cardNumber, string pin)
        {
            var account = GetAccount(cardNumber, pin);

            if (account == null)
            {
                throw new InValidPinException("invalidPin");
            }

            return account;
        }


    }
}