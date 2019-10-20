using Acelera.OO.CarRental.VehicleOptional;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Vehicle
{
    public class MotorHome : IVehicle
    {
        public decimal DailyRate => 300;
        public decimal KmRate => 0.65M;
        public List<VehicleOptional.VehicleOptional> AvailableOptionals { get; } = new List<VehicleOptional.VehicleOptional>() {
            new VehicleOptional.VehicleOptional(VehicleOptionalEnum.Gps, 35),
            new VehicleOptional.VehicleOptional(VehicleOptionalEnum.ChildSeat, 75),
            new VehicleOptional.VehicleOptional(VehicleOptionalEnum.Fridge, 250)
        };
    }
}