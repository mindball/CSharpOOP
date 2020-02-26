namespace RealWorldCodeExample
{
    public class Customer
    {
        private string name;   

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}