using System;
using System.Collections.Generic;
using System.Linq;
public class Tire
{
    //double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age
    public Tire(double tirePressure, int tireAge)
    {
        this.TirePressure = tirePressure;
        this.TireAge = tireAge;
    }
    public double TirePressure { get; set; }
    public int TireAge { get; set; }

}


