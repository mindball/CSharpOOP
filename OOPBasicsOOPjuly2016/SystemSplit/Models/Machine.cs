using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemSplit.Contracts;

namespace SystemSplit.Models
{
    class Machine
    {

        private const string ExpressSoftware = "ExpressSoftware";
        private const string LightSoftware = "LightSoftware";

        private IList<IComponentHardware> hardwareComponents;
        IList<IComponentHardware> dumpHardwareComponents ;

        public Machine()
        {
            this.hardwareComponents = new List<IComponentHardware>();
            this.dumpHardwareComponents = new List<IComponentHardware>();
        }

        public int CountHardwareComponents => this.hardwareComponents.Count;
        public int CountSoftwareComponents => this.hardwareComponents.Sum(x => x.SoftwareComponets.Count);
        public int MaximumMemory => this.hardwareComponents.Sum(x => x.MaxMemory);       
        public int MaximumCapacity => hardwareComponents.Sum(x => x.MaxCapacity);
        public int TotalOperationalMemoryInUse =>
            this.hardwareComponents.Sum(x => x.SoftwareComponets.Sum(y => y.MemoryConsumption)); 
        public int TotalOperationalCapacityInUse =>
            this.hardwareComponents.Sum(x => x.SoftwareComponets.Sum(y => y.CapacityConsumption));

        public int GetMemoryUsed(IComponentHardware currentHardware)
        {
            int memory = currentHardware.SoftwareComponets.Sum(x => x.MemoryConsumption);
            return memory;
        }

        public int GetCapacityUsed(IComponentHardware currentHardware)
        {
            int capacity = currentHardware.SoftwareComponets.Sum(x => x.CapacityConsumption);
            return capacity;
        }

        public void AddHardwareItem(IComponentHardware item)
        {
            this.hardwareComponents.Add(item);
        }

        public void AddSoftwareItem(string hardwareItem, IComponentSoftware item)
        {
            var hardwareType = this.hardwareComponents.
                FirstOrDefault(x => x.Name == hardwareItem);


            if (hardwareType != null &&
                item.MemoryConsumption <= hardwareType.MaxMemory &&
                item.CapacityConsumption <= hardwareType.MaxCapacity)
            {
                hardwareType.AddSoftwareComponent(item);
            }
        }

        public void ReleaseSoftwareComponent(string nameOfHardware, string softwareComponent)
        {
            var hardware = GetHardwareItem(nameOfHardware);
            if (hardware != null)
            {
                IComponentSoftware componentToRemove =
                    hardware.SoftwareComponets
                    .SingleOrDefault(x => x.Name == softwareComponent);

                hardware.SoftwareComponets.Remove(componentToRemove);                
            }
        }

        private int GetCountOfSpecificSoftwareComponets(IComponentHardware hardware,
            string nameOfSoftware)
        {

            int countSoftware = hardware.SoftwareComponets
                .Where(x => x.GetType().Name.Contains(nameOfSoftware))
                .Count();

            return countSoftware;
        }

        public void Analyze()
        {
            Console.WriteLine("System Analysis");
            Console.WriteLine($"Hardware Components: {this.CountHardwareComponents}");
            Console.WriteLine($"Software Components: {this.CountSoftwareComponents}");
            Console.WriteLine($"Total Operational Memory: " +
                $"{this.TotalOperationalMemoryInUse} / {this.MaximumMemory}");
            Console.WriteLine($"Total Capacity Taken: " +
                $"{this.TotalOperationalCapacityInUse} / {this.MaximumCapacity}");
        }

        public void SystemSplit()
        {
            StringBuilder hardwareStatusMsg = new StringBuilder();
            foreach (var hardwareItm in this.hardwareComponents)
            {

                hardwareStatusMsg.AppendLine($"Hardware Component - {hardwareItm.Name}");

                int countExpressSoft =
                    this.GetCountOfSpecificSoftwareComponets(hardwareItm, ExpressSoftware);
                int countLightSoft =
                   this.GetCountOfSpecificSoftwareComponets(hardwareItm, LightSoftware);
                hardwareStatusMsg.AppendLine($"Express Software Components - " +
                    $"{countExpressSoft}");
                hardwareStatusMsg.AppendLine($"Light Software Components - " +
                    $"{countLightSoft}");

                hardwareStatusMsg.AppendLine($"Memory usage: " +
                    $"{this.GetMemoryUsed(hardwareItm)} / {hardwareItm.MaxMemory}");
                hardwareStatusMsg.AppendLine($"Capacity Usage: " +
                    $"{this.GetCapacityUsed(hardwareItm)} / {hardwareItm.MaxCapacity}");

                hardwareStatusMsg.AppendLine($"Type: {hardwareItm.TypeOfHardware}");

                var hardwareContainedSoftComponents
                    = string.Join(", ",
                    hardwareItm.SoftwareComponets
                       .Select(p => p.Name.ToString())).TrimEnd();
                hardwareStatusMsg.AppendLine($"Software Components: {hardwareContainedSoftComponents}");
            }
            Console.WriteLine(hardwareStatusMsg.ToString());
        }

        private IComponentHardware GetHardwareItem(string name)
        {
            var hardware = this.hardwareComponents.
               FirstOrDefault(x => x.Name == name);

            return hardware;
        }
        
    }
     
}
