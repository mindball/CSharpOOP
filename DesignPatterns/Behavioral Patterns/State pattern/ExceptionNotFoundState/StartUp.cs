using ExceptionNotFoundState.Models;
using System;

namespace ExceptionNotFoundState
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Steak account = new Steak("T-Bone");

            account.AddTemp(120);
            account.AddTemp(15);
            account.AddTemp(15);
            account.RemoveTemp(10);
            account.RemoveTemp(15);
            account.AddTemp(20);
            account.AddTemp(20);
            account.AddTemp(20);

        }
    }
}
