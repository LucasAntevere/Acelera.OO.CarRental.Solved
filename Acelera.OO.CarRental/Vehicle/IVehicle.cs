using System.Collections.Generic;

namespace Acelera.OO.CarRental.Vehicle
{
    public interface IVehicle
    {
        decimal DailyRate { get; }
        decimal KmRate { get; }
        List<VehicleOptional.VehicleOptional> AvailableOptionals { get; }
    }
}
