namespace VirtualAtm.Services
{
    public interface IAtmService
    {
        void Withdraw(string cardNumber, string pin, double amount);
        void Deposit(string cardNumber, string pin, double amount);
    }
}