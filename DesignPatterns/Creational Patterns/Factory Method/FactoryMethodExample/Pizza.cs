using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    public abstract class Pizza : IPizza
    {
        private string  name;
        private string  souce;
        private string dough;

        public Pizza(string name, string souce, string dough)
        {
            this.Name = name;
            this.Souce = souce;
            this.Dough = dough;
        }

        public string  Name
        {
            get { return name; }
            set { name = value; }
        }

        public string  Souce
        {
            get { return souce; }
            set { souce = value; }
        }

        public string Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public abstract void Prepare();

        public override string ToString()
        {
            return $"{this.Name}";
        }

    }
}
