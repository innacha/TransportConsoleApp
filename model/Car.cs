using TransportConsoleApp.dictionary;

namespace TransportConsoleApp.model
{
    class Car
    {
        public CarType CarType { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int VehicleCapacity { get; set; }
        public int PassengerCapacity { get; set; }
        public int Weight { get; set; }
        public double EnginePower { get; set; }
        public double FuelConsumption { get; set; }

        public override string ToString()
        {
            return "Car: " + Brand + " " + Model + " Year:" + Year + " EnginePower:" + EnginePower + " PassengerCapacity:" + PassengerCapacity + " CarType:" + CarType;
        }
    }
}
