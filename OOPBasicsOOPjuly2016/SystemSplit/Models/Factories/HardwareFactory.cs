using SystemSplit.Contracts;

namespace SystemSplit.Models.Factories
{
    class HardwareFactory
    {
        public IComponentHardware CreateHardware(string type, 
            string name, int capacity, int memory)
        {
            IComponentHardware componentHardware = null;
            switch(type)
            {
                case "PowerHardware":
                    return componentHardware = new PowerHardware(name, capacity, memory, type);
                    break;
                case "HeavyHardware":
                    return componentHardware = new HeavyHardware(name, capacity, memory, type);
                    break;
            }

            return componentHardware;
        }
    }
}
