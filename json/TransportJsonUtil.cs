using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TransportConsoleApp.dictionary;
using TransportConsoleApp.model;

namespace TransportConsoleApp.json
{
    class TransportJsonUtil
    {
        public static string DEFAULT_PATH = "C:\\TransportLibrary\\transportConsoleApp.json";
        public void ToJson()
        {
            try
            {
                List<Car> cars = Transport.Cars;
                string json = JsonConvert.SerializeObject(cars);
                File.WriteAllText(GetPath(), json);
                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void FromJson()
        {
            try
            {
                string json = File.ReadAllText(GetPath());
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                Transport.Cars = cars;
                cars.ForEach(i => Console.WriteLine("{0}\t", i));
            }
            catch (JsonReaderException)
            {
                Console.WriteLine("Could not read/parse Json file");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find file. Please check the path");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private string GetPath()
        {
            Console.Write("Enter the path or press Enter to use default (" + DEFAULT_PATH + "): ");
            string inputPath = Console.ReadLine();
            string path;
            if (inputPath.Length == 0)
            {
                path = DEFAULT_PATH;
            }
            else
            {
                path = inputPath;
            }
            return path;
        }
    }
}
