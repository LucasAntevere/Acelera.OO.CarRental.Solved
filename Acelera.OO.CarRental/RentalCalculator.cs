using Acelera.OO.CarRental.Rent;
using Acelera.OO.CarRental.Vehicle;
using Acelera.OO.CarRental.Vehicle.Factory;
using Acelera.OO.CarRental.VehicleOptional;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental
{
    public class RentalCalculator
    {
        private readonly IVehicleFactory _vehicleFactory;

        public RentalCalculator(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        public RentalResult Calculate(List<Rent> rents)
        {
            var result = new RentalResult();

            foreach (var rent in rents)
                result.RentResults.Add(CalculateRental(rent));

            return result;
        }

        private RentResult CalculateRental(Rent rent)
        {
            var result = new RentResult(rent);

            result.Vehicle = _vehicleFactory.Build(rent.VehicleType);
            result.TotalDays = CalculateTotalDays(rent.StartDate, rent.StopDate.Date);
            result.Optionals = GetOptionals(result.Vehicle, rent.Optionals).ToList();
            result.OptionalsValue = result.Optionals.Sum(x => x.Rate);
            result.EstimateKmValue = result.Vehicle.KmRate * rent.EstimateKm;
            result.TotalDaysValue = result.TotalDays * result.Vehicle.DailyRate;
            result.TotalValue = result.TotalDaysValue + result.OptionalsValue + result.EstimateKmValue;

            return result;
        }

        private int CalculateTotalDays(DateTime startDate, DateTime stopDate)
        {
            var totalDays = (int)(stopDate.Date - startDate.Date).TotalDays;

            return totalDays == 0 ? 1 : totalDays;
        }

        private IEnumerable<VehicleOptional> GetOptionals(IVehicle vehicle, List<VehicleOptionalEnum> optionals)
        {
            foreach (var optional in optionals)
            {
                var vehicleOptional = vehicle.AvailableOptionals.FirstOrDefault(x => x.Type == optional);

                if (vehicleOptional == null)
                    throw new ArgumentException($"{optional} optional not available for {vehicle.GetType()}");

                yield return vehicleOptional;
            }
        }
    }
}