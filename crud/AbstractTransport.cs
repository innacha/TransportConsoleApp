using System;
using System.Text;
using TransportConsoleApp.dictionary;

namespace TransportConsoleApp.crud
{
    abstract class AbstractTransport
    {
        protected CarType readCarType()
        {
            Console.Write("Enter CardType ({0}): ", GetStringCarTypes());
            string enumString = Console.ReadLine();
            CarType convertedEnum;
            bool success = Enum.TryParse(enumString, true, out convertedEnum) && Enum.IsDefined(typeof(CarType), enumString);
            if (success)
            {
                return convertedEnum;

            }
            else
            {
                pleaseEnterCorrect("CarType");
                return readCarType();
            }
        }

        protected Brand readBrand()
        {
            Console.Write("Enter Brand ({0}): ", GetStringCarBrands());
            string enumString = Console.ReadLine();
            Brand convertedEnum;
            bool success = Enum.TryParse(enumString, true, out convertedEnum) && Enum.IsDefined(typeof(Brand), enumString);
            if (success)
            {
                return convertedEnum;
            }
            else
            {
                pleaseEnterCorrect("Brand");
                return readBrand();
            }
        }

        protected String readModel()
        {
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            return model;
        }

        protected Int32 readInteger(string fieldName, int from, int to)
        {
            Console.Write("Enter {0} (from {1:D} to {2:D}): ", fieldName, from, to);
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < from || number > to)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }
            catch (Exception e)
            {
                Console.WriteLine("You entered incorrect value. Please input again! " + e.Message);
                return readInteger(fieldName, from, to);
            }
        }

        protected double readDouble(string fieldName, double from, double to)
        {
            Console.Write("Enter {0} (from {1:N} to {2:N}): ", fieldName, from, to);
            try
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number < from || number > to)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }
            catch (Exception e)
            {
                Console.WriteLine("You entered incorrect value. Please input again! " + e.Message);
                return readDouble(fieldName, from, to);
            }
        }

        private string GetStringCarTypes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in Enum.GetNames(typeof(CarType))) sb.Append(s + ", ");
            return sb.ToString();
        }

        private string GetStringCarBrands()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in Enum.GetNames(typeof(Brand))) sb.Append(s + ", ");
            return sb.ToString();
        }

        private void pleaseEnterCorrect(string str)
        { 
            Console.WriteLine("*** Please Enter correct {0}! ***", str); 
        }
    }
}
