namespace Acelera.OO.CarRental.VehicleOptional
{
    public class VehicleOptional
    {
        public VehicleOptional(VehicleOptionalEnum type, decimal rate)
        {
            Type = type;
            Rate = rate;
        }

        public VehicleOptionalEnum Type { get; set; }
        public decimal Rate { get; set; }
    }
}