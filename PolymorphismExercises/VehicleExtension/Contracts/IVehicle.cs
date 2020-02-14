namespace VehicleExtension.Contracts
{
    public interface IVehicle
    {
        //Car and truck both have fuel quantity, fuel consumption 
        //TODO validy check
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        bool IsEmptyVehicle { get; set; }

        void Drive(double distance);
        void ReFuel(double fuelQuantity);


    }
}
