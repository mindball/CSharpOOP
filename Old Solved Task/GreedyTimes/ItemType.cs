using System;
using System.Collections.Generic;

class ItemType
{
    public string Name { get; set; }
    public long Quantity { get; set; }

    public void IncreaseQuantity(long quantity)
    {
        Quantity += quantity;
    }   
    
}


