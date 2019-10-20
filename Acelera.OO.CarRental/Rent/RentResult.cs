using Acelera.OO.CarRental.Vehicle;
using System.Collections.Generic;

namespace Acelera.OO.CarRental.Rent
{
    public class RentResult
    {
        public Rent Rent { get; }

        public RentResult(Rent rent)
        {
            Rent = rent;
            Optionals = new List<VehicleOptional.VehicleOptional>();
        }
                
        public IVehicle Vehicle { get; set; }
        public List<VehicleOptional.VehicleOptional> Optionals { get; set; }
        public int TotalDays { get; set; }

        public decimal OptionalsValue { get; set; }
        public decimal EstimateKmValue { get; set; }
        public decimal TotalDaysValue { get; set; }
        public decimal TotalValue { get; set; }        
    }
}
