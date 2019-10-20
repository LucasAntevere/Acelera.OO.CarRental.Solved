namespace Acelera.OO.CarRental.Vehicle.Factory
{
    public interface IVehicleFactory
    {
        IVehicle Build(VehicleTypeEnum type);
    }
}