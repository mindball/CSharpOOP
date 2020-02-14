namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        //Car and truck both have fuel quantity, fuel consumption 
        //TODO validy check
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        void Drive(double distance);
        void ReFuel(double fuelQuantity);
    }
}
