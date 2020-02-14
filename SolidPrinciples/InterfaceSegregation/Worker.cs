namespace InterfaceSegregation
{
    public abstract class Worker : ISleeper
    {
        private string id;
        private int workingHours;

        public Worker(string id)
        {
            this.Id = id;
        }

        public int WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public abstract void Sleep();

    }
}
