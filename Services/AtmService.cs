using VirtualAtm.Exceptions;

namespace VirtualAtm.Services
{
    public class AtmService : IAtmService
    {

        private readonly IAccountService _accountService;
        private static readonly object SyncLock = new object();


        public AtmService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public virtual void Withdraw(string cardNumber, string pin, double amount)
        {

            var account = _accountService.VerifyPinAndGetAccount(cardNumber, pin);
            lock (SyncLock)
            {
                if (account.Balance - amount < 0)
                    throw new MinimumBalanceException("");

                account.Balance -= amount;
            }
        }

        public virtual void Deposit(string cardNumber, string pin, double amount)
        {
            var account = _accountService.VerifyPinAndGetAccount(cardNumber, pin);
            lock (SyncLock)
            {
                account.Balance += amount;
            }
        }


    }
}