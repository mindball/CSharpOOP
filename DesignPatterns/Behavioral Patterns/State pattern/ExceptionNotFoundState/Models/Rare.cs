namespace ExceptionNotFoundState.Models
{
    public class Rare : Doneness
    {
        public Rare(Doneness state) 
            : this(state.CurrentTemp, state.Steak)
        {
        }

        public Rare(double currentTemp, Steak steak)
        {
            this.CurrentTemp = currentTemp;
            this.Steak = steak;
            this.Initialize();
        }

        private void Initialize()
        {
            this.lowerTemp = 130;
            this.upperTemp = 139.9999999;
            this.canEat = true;            
        }

        public override void AddTemp(double amount)
        {
            this.CurrentTemp += amount;
            this.DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (this.CurrentTemp < this.lowerTemp)
                this.Steak.State = new Uncooked(this);
            else if (this.CurrentTemp > this.upperTemp)
                this.Steak.State = new MediumRare(this);
        }

        public override void RemoveTemp(double amount)
        {
            this.CurrentTemp -= amount;
            this.DonenessCheck();
        }
    }
}
