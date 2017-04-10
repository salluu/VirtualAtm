using System;

namespace VirtualAtm.Exceptions
{
    public class MinimumBalanceException : Exception
    {
        public MinimumBalanceException(string message) : base(message)
        {
        }
    }
}