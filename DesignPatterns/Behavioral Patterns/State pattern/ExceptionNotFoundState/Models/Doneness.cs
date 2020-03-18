namespace ExceptionNotFoundState.Models
{
    public abstract class Doneness
    {
        protected Steak steak;
        protected double currentTemp;
        protected double lowerTemp;
        protected double upperTemp;
        protected bool canEat;

        public double CurrentTemp { get => this.currentTemp; set => this.currentTemp = value; }
        public Steak Steak { get => this.steak; set => this.steak = value; }

        public abstract void AddTemp(double amount);
        public abstract void RemoveTemp(double amount);
        public abstract void DonenessCheck();
    }
}
