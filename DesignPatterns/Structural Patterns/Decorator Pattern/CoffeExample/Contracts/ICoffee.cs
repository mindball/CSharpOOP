using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeExample.Contracts
{
    public interface ICoffee
    {
        string GetDescription();
        double Cost();
    }
}
