namespace ExceptionNotFoundState.Models
{
    public class Medium : Doneness
    {
        public Medium(Doneness state)
            : this(state.CurrentTemp, state.Steak)
        {            
        }

        public Medium(double currentTemp, Steak steak)
        {
            this.CurrentTemp = currentTemp;
            this.steak = steak;            
            Initialize();
        }

        public override void AddTemp(double amount)
        {
            this.CurrentTemp += amount;            
            this.DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (this.CurrentTemp < 130)
                this.Steak.State = new Uncooked(this);            
            else if (this.CurrentTemp < this.lowerTemp)
                this.Steak.State = new MediumRare(this);
            else if (this.CurrentTemp > this.upperTemp)
                this.Steak.State = new WellDone(this);
        }

        public override void RemoveTemp(double amount)
        {
            this.CurrentTemp -= amount;
            this.DonenessCheck();
        }

        private void Initialize()
        {
            this.lowerTemp = 155;
            this.upperTemp = 169.99999;
            this.canEat = true;
        }
    }
}