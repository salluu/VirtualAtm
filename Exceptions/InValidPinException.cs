using System;

namespace VirtualAtm.Exceptions
{
    public class InValidPinException : Exception
    {
        public InValidPinException(string message) : base(message)
        {
        }
    }
}