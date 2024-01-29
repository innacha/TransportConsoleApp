using System.Collections.Generic;
using TransportConsoleApp.model;

namespace TransportConsoleApp.dictionary
{
    static class Transport
    {
        public static List<Car> Cars { get; set; }

        static Transport()
        {
            Cars = new List<Car>
            {
                new Car
                {
                    CarType = CarType.Passenger,
                    Brand = Brand.Audi,
                    Model = "A6",
                    Year = 2001,
                    VehicleCapacity = 800,
                    PassengerCapacity = 5,
                    Weight = 1800,
                    EnginePower = 150.5,
                    FuelConsumption = 12
                },
                new Car
                {
                    CarType = CarType.Passenger,
                    Brand = Brand.VW,
                    Model = "Golf",
                    Year = 2021,
                    VehicleCapacity = 750,
                    PassengerCapacity = 5,
                    Weight = 1600,
                    EnginePower = 200,
                    FuelConsumption = 10
                },
                new Car
                {
                    CarType = CarType.Truck,
                    Brand = Brand.VW,
                    Model = "Transporter",
                    Year = 2020,
                    VehicleCapacity = 2000,
                    PassengerCapacity = 3,
                    Weight = 2200,
                    EnginePower = 110,
                    FuelConsumption = 9
                },
                new Car
                {
                    CarType = CarType.Bus,
                    Brand = Brand.VW,
                    Model = "LT 46",
                    Year = 2018,
                    VehicleCapacity = 3000,
                    PassengerCapacity = 15,
                    Weight = 4000,
                    EnginePower = 250,
                    FuelConsumption = 12
                }
            };
        }
    }
}
