using System;
using System.Collections.Generic;
using System.Linq;

class Gold : ItemType
{
    public Gold(string name, long quantity)
    {
        this.Name = name;
        Quantity += quantity;
    }
        

}

