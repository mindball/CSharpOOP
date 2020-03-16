namespace DemoFromXxceptionNotFound
{
    public class SupplierMemory
    {
        private FoodSupplierMemento _memento;
        public FoodSupplierMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
