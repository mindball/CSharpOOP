using System;
using System.Collections.Generic;
using System.Linq;

public class Cargo
{
    public Cargo(int cargoWeight, string cargoType)
    {
        this.CargoType = cargoType;
        this.CargoWeight = cargoWeight;
    }
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
}


