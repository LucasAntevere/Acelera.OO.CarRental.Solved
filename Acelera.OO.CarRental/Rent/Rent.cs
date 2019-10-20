using Acelera.OO.CarRental.Vehicle;
using Acelera.OO.CarRental.VehicleOptional;
using System;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Rent
{
    public class Rent
    {
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public VehicleTypeEnum VehicleType { get; set; }
        public int EstimateKm { get; set; }
        public List<VehicleOptionalEnum> Optionals { get; set; }
    }
}
