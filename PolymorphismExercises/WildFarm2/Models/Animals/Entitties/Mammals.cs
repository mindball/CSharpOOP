namespace WildFarm2.Models.Animals.Entitties
{
    public abstract class Mammals : Animal
    {
        public Mammals(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }       
    }
}
