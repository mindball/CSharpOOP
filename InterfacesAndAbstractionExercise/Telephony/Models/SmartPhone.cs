
using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class SmartPhone : IBrowseable, ICallable
    {
        public string Browse(string url)
        {
           if(url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }

        public string Calling(string phoneNumber)
        {
            if(!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNumber}";
        }
    }
}
