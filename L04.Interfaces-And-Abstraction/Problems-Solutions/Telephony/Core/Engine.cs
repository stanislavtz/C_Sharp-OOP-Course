using System;
using System.Collections.Generic;
using System.Linq;
using Telephony.Exceptions;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine
    {
        private readonly Smartphone phone;

        public Engine()
        {
            this.phone = new Smartphone();
        }

        public Engine(Smartphone phone)
        {
            this.phone = phone;
        }

        public void Run()
        {
            List<string> phoneNumbers = Console.ReadLine().Split().ToList();
            List<string> urls = Console.ReadLine().Split().ToList();

            CallingNumbers(phoneNumbers);
            BrowsingURLs(urls);
        }

        private void CallingNumbers(List<string> phoneNumbers)
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.phone.Call(phoneNumber));
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void BrowsingURLs(List<string> urls)
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.phone.Browse(url));
                }
                catch (InvalidURLException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
