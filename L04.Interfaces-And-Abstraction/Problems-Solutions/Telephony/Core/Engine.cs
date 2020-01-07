using System;
using System.Linq;
using Telephony.Models;
using Telephony.Exceptions;
using System.Collections.Generic;
using Telephony.Contracts;

namespace Telephony.Core
{
    public class Engine
    {
        public void Run()
        {
            List<string> phoneNumbers = Console.ReadLine().Split().ToList();
            List<string> urls = Console.ReadLine().Split().ToList();

            Smartphone phone = new Smartphone();

            CallingNumbers(phoneNumbers, phone);
            BrowsingURLs(urls, phone);
        }

        private static void BrowsingURLs(List<string> urls, IBrowseable phone)
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(phone.Browse(url));
                }
                catch (InvalidURLException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void CallingNumbers(List<string> phoneNumbers, ICallable phone)
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
