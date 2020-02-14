using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Car
{
    private const string offset = "  ";
    private string model;
    private Engine engine;
    int? weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = null;
        this.color = "";
    }

    public Car(string model, Engine engine, int weight)
        :this(model, engine)
    {
        this.weight = weight;
    }

    public Car(string model, Engine engine, string color)
        : this(model, engine)
    {
        this.color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        : this(model, engine)
    {
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}:\n", this.model);
        sb.Append(this.engine.ToString());
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight.HasValue ? this.weight.ToString() : "n/a");
        sb.AppendFormat("{0}Color: {1}", offset, string.IsNullOrEmpty(this.color) ? "n/a" : this.color);

        return sb.ToString();
    }
}

