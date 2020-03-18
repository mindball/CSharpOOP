namespace ExceptionNotFoundState.Models
{
    public class WellDone : Doneness
    {
        public WellDone(Doneness state)
             : this(state.CurrentTemp, state.Steak)   
        {           
        }

        public WellDone(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            this.canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            this.lowerTemp = 170;
            this.upperTemp = 230;
        }

        public override void AddTemp(double amount)
        {
            this.CurrentTemp += amount;
            this.DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (this.CurrentTemp < 0)
                this.Steak.State = new Uncooked(this);
            else if (this.CurrentTemp < this.lowerTemp)
                this.Steak.State = new Medium(this);
        }

        public override void RemoveTemp(double amount)
        {
            this.CurrentTemp -= amount;
            this.DonenessCheck();
        }
    }
}