using System;
using System.Collections.Generic;
using System.Text;

namespace DIWithConstructorParams
{
    public class MyService : IMyService
    {
        private string connectionString;
        public MyService(string connString)
        {
            this.connectionString = connString;
        }

        public string GetConstructorParameter()
        {
            return connectionString;
        }
    }
}
