namespace DemoFromXxceptionNotFound
{
    public class FoodSupplierMemento
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public FoodSupplierMemento(string name, string phone, string address)
        {
            this.Name = name;
            this.PhoneNumber = phone;
            this.Address = address;
        }
    }
}
