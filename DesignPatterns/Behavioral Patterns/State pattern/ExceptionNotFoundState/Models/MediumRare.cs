namespace ExceptionNotFoundState.Models
{
    public class MediumRare : Doneness
    {
        public MediumRare(Doneness state)
            : this(state.CurrentTemp, state.Steak)
        {
        }

        public MediumRare(double currentTemp, Steak steak)
        {
            this.CurrentTemp = currentTemp;
            this.Steak = steak;           
            Initialize();
        }

        private void Initialize()
        {
            this.canEat = true;
            this.lowerTemp = 140;
            this.upperTemp = 154.9999999;
        }

        public override void AddTemp(double amount)
        {
            this.CurrentTemp += amount;
            this.DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (this.CurrentTemp < 0.0)
                this.Steak.State = new Uncooked(this);
            else if (this.CurrentTemp < this.lowerTemp)
                this.Steak.State = new Rare(this);
            else if (this.CurrentTemp > this.upperTemp)
                this.Steak.State = new Medium(this);
        }

        public override void RemoveTemp(double amount)
        {
            this.CurrentTemp -= amount;
            this.DonenessCheck();
        }
    }
}
