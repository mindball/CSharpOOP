using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Engine
{
    private const string offset = "  ";
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;

    
    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
        this.displacement = null;
        this.efficiency = "";
    }

    public Engine(string model, int power, int displacement) 
        :this(model, power)
    {
        this.displacement = displacement;
    }

    public Engine(string model, int power, string efficiency)
        : this(model, power)
    {
        this.efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}{1}:\n", offset, this.model);
        sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
        sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement.HasValue ? this.displacement.ToString() : "n/a");
        sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, string.IsNullOrEmpty(this.efficiency) ? "n/a" : this.efficiency);
        
        return sb.ToString();
    }
}

