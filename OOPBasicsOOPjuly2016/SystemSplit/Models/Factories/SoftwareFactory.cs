using SystemSplit.Contracts;

namespace SystemSplit.Models.Factories
{
    class SoftwareFactory
    {
        public IComponentSoftware CreateSoftware(string type, 
            string name, int capacity, int memory)
        {
            IComponentSoftware componentSoftware = null;
            switch(type)
            {
                case "LightSoftware":
                    return componentSoftware = new LightSoftware(name, capacity, memory);
                    break;
                case "ExpressSoftware":
                    return componentSoftware = new ExpressSoftware(name, capacity, memory);
                    break;
            }

            return componentSoftware;
        }
    }
}
