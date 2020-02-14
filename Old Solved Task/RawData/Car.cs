using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    public Car(string model, Engine engine, Cargo cargo, List<Tire> tire)
    {
        this.Model = model;
        this.Cargo = cargo;
        this.Engine = engine;
        this.Tire = tire;
    }

    public string Model { get; set; }
    public Cargo Cargo { get; set; }
    public Engine Engine { get; set; }
    public List<Tire> Tire { get; set; }

}

