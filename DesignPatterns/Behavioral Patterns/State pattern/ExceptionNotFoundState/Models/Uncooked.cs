namespace ExceptionNotFoundState.Models
{
    public class Uncooked : Doneness
    {
        public Uncooked(Doneness state)
        {
            this.CurrentTemp = state.CurrentTemp;
            this.Steak = state.Steak;
            Initialize();
        }

        private void Initialize()
        {
            this.lowerTemp = 0;
            this.upperTemp = 130;
            this.canEat = false;
        }

        public override void AddTemp(double amount)
        {
            this.CurrentTemp += amount;
            this.DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (this.CurrentTemp > this.upperTemp)
            {
                this.Steak.State = new Rare(this);
            }
        }

        public override void RemoveTemp(double amount)
        {
            this.CurrentTemp -= amount;
            this.DonenessCheck();
        }
    }
}
