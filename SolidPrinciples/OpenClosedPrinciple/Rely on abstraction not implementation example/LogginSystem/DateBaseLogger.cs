using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple.After
{
    public class DateBaseLogger : ILoggable
    {
        public void Log(Exception ex)
        {
            DB.Query("DB", ex.Message);

        }
    }
}
