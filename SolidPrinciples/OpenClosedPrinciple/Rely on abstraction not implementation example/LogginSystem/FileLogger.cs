using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple.After
{
    public class FileLogger : ILoggable
    {
        public void Log(Exception ex)
        {
            File.WriteAllText("access.login.txt", ex.Message);
        }
    }
}
