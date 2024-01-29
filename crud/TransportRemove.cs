using System;
using System.Collections.Generic;
using TransportConsoleApp.dictionary;
using TransportConsoleApp.model;

namespace TransportConsoleApp.crud
{
    class TransportRemove
    {
        public void Remove()
        {
            if (Transport.Cars.Count == 0)
            {
                Console.Write("Nothing to remove! Please add Transport first.");
                return;
            }

            try
            {
                Console.Write("Enter the index to remove: ");
                int index = Convert.ToInt32(Console.ReadLine());
                List<Car> cars = Transport.Cars;
                Car car = cars[index];
                cars.RemoveAt(index);
                Console.WriteLine("- Removed " + car);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index is out of range. Please input another one!");
                Remove();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter digital index!");
                Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Remove();
            }

        }
    }
}
