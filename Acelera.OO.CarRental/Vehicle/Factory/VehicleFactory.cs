using System;

namespace Acelera.OO.CarRental.Vehicle.Factory
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle Build(VehicleTypeEnum type)
        {
            switch (type)
            {
                case VehicleTypeEnum.Car:
                    return new Car();
                case VehicleTypeEnum.MotorHome:
                    return new MotorHome();
                default:
                    throw new NotImplementedException($"{type} not implemented");
            }
        }
    }
}
