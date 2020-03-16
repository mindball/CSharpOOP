using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottlillyExampleMemento
{
    public class CustomerMultipleMemento
    {
        List<CustomerMemento> customerMementoes = new List<CustomerMemento>();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        public CustomerMultipleMemento(int id, string name, string address,
            string city, string stateProvince, string postalCode)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.StateProvince = stateProvince;
            this.PostalCode = postalCode;

            // Save the originally-passed values to the memento list.
            this.SaveMemento();
        }

        public void SaveMemento()
        {
            CustomerMemento customerMemento = new
                CustomerMemento(this.Name, this.Address, this.City, this.StateProvince, this.PostalCode);

            this.customerMementoes.Add(customerMemento);
        }

        public void ReverToLastValues()
        {
            CustomerMemento lastMemento = this.customerMementoes.LastOrDefault();

            if(lastMemento != null)
            {
                SetPropertyValuesFormMemento(lastMemento);
            }
        }

        private void SetPropertyValuesFormMemento(CustomerMemento lastMemento)
        {
            this.Name = lastMemento.Name;
            this.Address = lastMemento.Address;
            this.City = lastMemento.City;
            this.StateProvince = lastMemento.StateProvince;
            this.PostalCode = lastMemento.PostalCode;
        }

        private class CustomerMemento
        {
            public string Name { get; private set; }
            public string Address { get; private set; }
            public string City { get; private set; }
            public string StateProvince { get; private set; }
            public string PostalCode { get; private set; }

            public CustomerMemento(string name, string address,
                string city, string stateProvince, string postalCode)
            {
                Name = name;
                Address = address;
                City = city;
                StateProvince = stateProvince;
                PostalCode = postalCode;
            }
        }
    }
}
