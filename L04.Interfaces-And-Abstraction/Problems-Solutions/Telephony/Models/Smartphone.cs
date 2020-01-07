using System.Linq;
using System.Text.RegularExpressions;
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
                throw new InvalidNumberException();
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            Regex reg = new Regex(@"([--:\w?@%&+~#=]*\.[a-z]{2,4}\/{0,2})((?:[?&](?:\w+)=(?:\w+))+|[--:\w?@%&+~#=]+)?");
            

            if (!reg.IsMatch(url) || url.Any(u => char.IsDigit(u)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }
    }
}
