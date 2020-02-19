using Example.Contracts;

namespace Example.Models
{
    public class SportsCarBuildDirector
    {
        private ICarBuilder builder;

        public SportsCarBuildDirector(ICarBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            this.builder.Color = "Red";
            this.builder.NumberOfDoor = 2;
        }
    }
}
