using Acelera.OO.CarRental.VehicleOptional;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Vehicle
{
    public class Car : IVehicle
    {
        public decimal DailyRate => 50;
        public decimal KmRate => 0.5M;
        public List<VehicleOptional.VehicleOptional> AvailableOptionals { get; } = new List<VehicleOptional.VehicleOptional>() {
            new VehicleOptional.VehicleOptional(VehicleOptionalEnum.Gps, 25),
            new VehicleOptional.VehicleOptional(VehicleOptionalEnum.ChildSeat, 65)
        };
    }
}
