using DemoExample.Contracts;
using System;
using System.Linq;

namespace DemoExample.Models
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            this.xmlConverter = xmlConverter;
        }
        public void ConvertXmlToJson()
        {
            var manufacturers = xmlConverter.GetXML()
                 .Element("Manufacturers")
                 .Elements("Manufacturer")
                 .Select(m => new Manufacturer
                 {
                     City = m.Attribute("City").Value,
                     Name = m.Attribute("Name").Value,
                     Year = Convert.ToInt32(m.Attribute("Year").Value)
                 });

            new JsonConverter(manufacturers)
            .ConvertToJson();
        }
    }
}
