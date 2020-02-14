using System;

namespace ExersiceEnumAndAttribute
{
    class TypeAttribute : Attribute
    {
        private const string typeOfAttribute = "Enumeration";

        public TypeAttribute(string category, string description)
        {
            this.Category = category;
            this.Description = description;
        }


        public string Type => typeOfAttribute;
        public string  Category { get; set; }
        public string  Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
