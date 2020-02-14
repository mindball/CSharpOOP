using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.After
{
    public interface ILoggable
    {
        void Log(Exception ex);
    }
}
