using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(n => !char.IsDigit(n)))
            {
                throw new InvalidNumber();
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            if (url.Any(u => char.IsDigit(u)))
            {
                throw new InvalidURL();
            }

            return $"Browsing: {url}!";
        }
    }
}
