using Acelera.OO.CarRental.Vehicle;
using Acelera.OO.CarRental.Vehicle.Factory;
using Acelera.OO.CarRental.VehicleOptional;
using CarRental;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class RentalCalculatorTests
    {
        [TestMethod]
        public void RentalCalculator_GivenCars_ReturnsValue()
        {
            var vehicleFactory = new VehicleFactory();
            var rentalCalculator = new RentalCalculator(vehicleFactory);

            var rents = new List<Rent.Rent>() {
                new Rent.Rent(){
                    VehicleType = VehicleTypeEnum.Car,
                    EstimateKm = 60,
                    Optionals = new List<VehicleOptionalEnum>(){
                        VehicleOptionalEnum.Gps
                    },
                    StartDate = new DateTime(2019, 10, 21, 11 ,0, 0),
                    StopDate = new DateTime(2019, 10, 23, 15, 0, 0)
                },
                new Rent.Rent(){
                    VehicleType = VehicleTypeEnum.MotorHome,
                    EstimateKm = 850,
                    Optionals = new List<VehicleOptionalEnum>(){
                        VehicleOptionalEnum.Gps,
                        VehicleOptionalEnum.Fridge
                    },
                    StartDate = new DateTime(2019, 10, 21, 17, 0, 0),
                    StopDate = new DateTime(2019, 10, 23, 09, 0, 0)
                }
            };

            var result = rentalCalculator.Calculate(rents);

            Assert.AreEqual(2, result.RentResults.Count);

            var car = result.RentResults[0];
            Assert.AreEqual(2, car.TotalDays);
            Assert.AreEqual(50M, car.Vehicle.DailyRate);
            Assert.AreEqual(30M, car.EstimateKmValue);
            Assert.AreEqual(1, car.Optionals.Count);
            Assert.AreEqual(25M, car.Optionals.First(x => x.Type == VehicleOptionalEnum.Gps).Rate);
            Assert.AreEqual(155M, car.TotalValue);

            var motorHome = result.RentResults[1];
            Assert.AreEqual(2, motorHome.TotalDays);
            Assert.AreEqual(600M, motorHome.TotalDaysValue);
            Assert.AreEqual(552.5M, motorHome.EstimateKmValue);
            Assert.AreEqual(2, motorHome.Optionals.Count);
            Assert.AreEqual(35M, motorHome.Optionals.First(x => x.Type == VehicleOptionalEnum.Gps).Rate);
            Assert.AreEqual(250M, motorHome.Optionals.First(x => x.Type == VehicleOptionalEnum.Fridge).Rate);
            Assert.AreEqual(1437.5M, motorHome.TotalValue);
        }
    }
}
