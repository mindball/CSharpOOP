using WildFarm2.Models.Foods.Contracts;

namespace WildFarm2.Models.Animals.Contracts
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        string AskFood();

        void Feed(IFood food);

    }
}
