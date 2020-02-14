using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine
    {
        private SmartPhone smartPhone;
        public Engine()
        {
            smartPhone = new SmartPhone();
        }

        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(smartPhone.Calling(phoneNumber)); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(url)); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
