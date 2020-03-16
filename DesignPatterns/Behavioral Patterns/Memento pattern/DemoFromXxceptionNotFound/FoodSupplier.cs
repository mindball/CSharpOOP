using System;

namespace DemoFromXxceptionNotFound
{
    public class FoodSupplier
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                Console.WriteLine("Proprietor:  " + this.name);
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                this.phone = value;
                Console.WriteLine("Phone Number: " + this.phone);
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
                Console.WriteLine("Address: " + this.address);
            }
        }

        public FoodSupplierMemento SaveMemento()
        {
            Console.WriteLine("\nSaving current state\n");
            return new FoodSupplierMemento(this.name, this.phone, this.address);
        }

        public void RestoreMemento(FoodSupplierMemento memento)
        {
            Console.WriteLine("\nRestoring previous state\n");
            this.Name = memento.Name;
            this.Phone = memento.PhoneNumber;
            this.Address = memento.Address;
        }
    }
}
