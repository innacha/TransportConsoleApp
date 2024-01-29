using System.Collections.Generic;
using System;
using TransportConsoleApp.dictionary;
using TransportConsoleApp.model;
using static TransportConsoleApp.util.AppConstant;

namespace TransportConsoleApp.crud
{
    class TransportUpdate : AbstractTransport
    {
        public void Update()
        {
            if (Transport.Cars.Count == 0)
            {
                Console.Write("Nothing to update! Please add Transport first.");
                return;
            }

            Car car = GetCar();
            Console.WriteLine("- Car before update: " + car);

            updateCarType(car);
            updateBrand(car);
            updateModel(car);
            updateYear(car);
            updateVehicleCapacity(car);
            updatePassengerCapacity(car);
            updateWeight(car);
            updateEnginePower(car);
            updateFuelConsumption(car);

            Console.WriteLine("- Updated: " + car);
        }

        private Car GetCar()
        {
            try
            {
                Console.Write("Enter the index to update: ");
                int index = Convert.ToInt32(Console.ReadLine());
                List<Car> cars = Transport.Cars;
                Car car = cars[index];
                return car;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index is out of range. Please input another one!");
                return GetCar();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter digital index!");
                return GetCar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return GetCar();
            }
        }

        private void updateCarType(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "CarType:", car.CarType);
            if (isNeedEdit()) car.CarType = readCarType();
        }

        private void updateBrand(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "Brand:", car.Brand);
            if (isNeedEdit()) car.Brand = readBrand();
        }

        private void updateModel(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "Model:", car.Model);
            if (isNeedEdit()) car.Model = readModel();
        }

        private void updateYear(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "Year:", car.Year);
            if (isNeedEdit()) car.Year = readInteger("year", 1900, 2024);
        }

        private void updateVehicleCapacity(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "VehicleCapacity:", car.VehicleCapacity);
            if (isNeedEdit()) car.VehicleCapacity = readInteger("vehicleCapacity", 100, 9999);
        }

        private void updatePassengerCapacity(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "PassengerCapacity:", car.PassengerCapacity);
            if (isNeedEdit()) car.PassengerCapacity = readInteger("passengerCapacity", 1, 40);
        }

        private void updateWeight(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "Weight:", car.Weight);
            if (isNeedEdit()) car.Weight = readInteger("weight", 500, 10000);
        }

        private void updateEnginePower(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "EnginePower:", car.EnginePower);
            if (isNeedEdit()) car.EnginePower = readDouble("enginePower", 1.0, 1000.0);
        }

        private void updateFuelConsumption(Car car)
        {
            Console.WriteLine("{0} {1} {2}", STARS, "FuelConsumption:", car.FuelConsumption);
            if (isNeedEdit()) car.FuelConsumption = readDouble("fuelConsumption", 1.0, 100.0);
        }

        private bool isNeedEdit()
        {
            Console.WriteLine(LEAVE_VALUE);
            string action = Console.ReadLine().ToLower().Trim();
            if (action.Length != 1) return isNeedEdit();
            if (action.Equals("s"))
            {
                return false;
            }
            else if (action.Equals("e"))
            {
                return true;
            } else
            {
                return isNeedEdit();
            }
        }
    }
}
