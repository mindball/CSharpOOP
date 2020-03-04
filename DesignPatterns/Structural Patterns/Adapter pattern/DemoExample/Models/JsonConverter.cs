using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace DemoExample.Models
{
    public class JsonConverter
    {
        private IEnumerable<Manufacturer> manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            this.manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(this.manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}
