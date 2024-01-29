using System;
using TransportConsoleApp.dictionary;
using TransportConsoleApp.model;

namespace TransportConsoleApp.crud
{
    class TransportCreate : AbstractTransport
    {
        public Car Create()
        {
            CarType carType = readCarType();
            Brand brand = readBrand();
            String model = readModel();
            int year = readInteger("year", 1900, 2024);
            int vehicleCapacity = readInteger("vehicleCapacity", 100, 9999);
            int passengerCapacity = readInteger("passengerCapacity", 1, 40);
            int weight = readInteger("weight", 500, 10000);
            double enginePower = readDouble("enginePower", 1.0, 1000.0);
            double fuelConsumption = readDouble("fuelConsumption", 1.0, 100.0);
            return new Car
            {
                CarType = carType,
                Brand = brand,
                Model = model,
                Year = year,
                VehicleCapacity = vehicleCapacity,
                PassengerCapacity = passengerCapacity,
                Weight = weight,
                EnginePower = enginePower,
                FuelConsumption = fuelConsumption
            };
        }
        
    }
}
