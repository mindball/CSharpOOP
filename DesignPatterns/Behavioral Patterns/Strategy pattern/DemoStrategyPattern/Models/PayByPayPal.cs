using DemoStrategyPattern.Contracts;
using System;
using System.Collections.Generic;

namespace DemoStrategyPattern.Models
{
    public class PayByPayPal : IPayStrategy
    {
        /// <summary>
        /// Represents a dictionary of user email accessed by password
        /// </summary>
        private readonly Dictionary<string, string> dataBase = new Dictionary<string, string>();
       
        private string inputEmailFromUser;
        private bool signedIn;
        private string inputPasswordFromUser;

        public PayByPayPal()
        {
            dataBase.Add("amanda1234", "asd@yahoo.com");
            dataBase.Add("123456", "tom@yahoo.com");
        }

        public void CollectPaymentDetails()
        {
            try
            {
                while(!signedIn)
                {
                    Console.Write("Enter the user's email: ");
                    inputEmailFromUser = Console.ReadLine();
                    Console.Write("Enter the user's password: ");
                    inputPasswordFromUser = Console.ReadLine();

                    if(Verify())
                    {
                        Console.WriteLine("Data verification has been successful.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong email or password!");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool Verify()
        {
            string checkEmail;
            if (this.dataBase.TryGetValue(this.inputPasswordFromUser, out checkEmail)
                && inputEmailFromUser.Equals(inputEmailFromUser))
            {
                this.signedIn = true;
                return this.signedIn;
            }
            else
            {
                this.signedIn = false;
                return this.signedIn;
            }
        }

        public bool Pay(int paymentAmount)
        {
            if(this.signedIn)
            {
                Console.WriteLine("Paying " + paymentAmount + " using PayPal.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
