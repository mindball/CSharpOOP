using Example3.Models;

namespace Example3.Contracts
{
    // IBicycleBuilder provides an interface for different Builders of Bicycle
    // ConcreteBuilder are like KidsBicycleBuilder, RoadBicycleBuilder, LadiesBicycleBuilder, MountainBicycleBuilder
    // A Concrete Builder have creation logic of parts which are assembled
    // to create a particular type (of different Representations) of bicycle.
    public interface IBicycleBuilder
    {
        void SetHeight(int height);
        void SetFrame();
        void SetGears();
        void PutTires();
        void SetColour(string colour);
        void PutAccessaries();
        Bicycle GetBicycle();
    }
}
