using System;

namespace DemoFromXxceptionNotFound
{
    class StartUp
    {
        static void Main(string[] args)
        {
            FoodSupplier s = new FoodSupplier();
            s.Name = "Harold Karstark";
            s.Phone = "(482) 555-1172";

            SupplierMemory memory = new SupplierMemory();
            memory.Memento = s.SaveMemento();

            s.Address = "548 S Main St. Nowhere, KS";

            s.RestoreMemento(memory.Memento);
        }
    }
}
