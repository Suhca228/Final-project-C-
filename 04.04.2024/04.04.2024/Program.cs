using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2024
{
    class Converter
    {
        public double LengthConverter(double value, string fromUnit, string toUnit)
        {
            // Довжина
            if (fromUnit.ToLower() == "m")
            {
                if (toUnit.ToLower() == "cm")
                    return value * 100;
                else if (toUnit.ToLower() == "km")
                    return value / 1000;
            }
            else if (fromUnit.ToLower() == "cm")
            {
                if (toUnit.ToLower() == "m")
                    return value / 100;
                else if (toUnit.ToLower() == "km")
                    return value / 100000;
            }
            else if (fromUnit.ToLower() == "km")
            {
                if (toUnit.ToLower() == "m")
                    return value * 1000;
                else if (toUnit.ToLower() == "cm")
                    return value * 100000;
            }

            return value;
        }

        public double WeightConverter(double value, string fromUnit, string toUnit)
        {
            // Вага
            if (fromUnit.ToLower() == "kg")
            {
                if (toUnit.ToLower() == "g")
                    return value * 1000;
                else if (toUnit.ToLower() == "lb")
                    return value * 2.20462;
            }
            else if (fromUnit.ToLower() == "g")
            {
                if (toUnit.ToLower() == "kg")
                    return value / 1000;
                else if (toUnit.ToLower() == "lb")
                    return value * 0.00220462;
            }
            else if (fromUnit.ToLower() == "lb")
            {
                if (toUnit.ToLower() == "kg")
                    return value * 0.453592;
                else if (toUnit.ToLower() == "g")
                    return value * 453.592;
            }

            return value;
        }

        public double VolumeConverter(double value, string fromUnit, string toUnit)
        {
            // Об'єм
            if (fromUnit.ToLower() == "l")
            {
                if (toUnit.ToLower() == "ml")
                    return value * 1000;
                else if (toUnit.ToLower() == "gal")
                    return value * 0.264172;
            }
            else if (fromUnit.ToLower() == "ml")
            {
                if (toUnit.ToLower() == "l")
                    return value / 1000;
                else if (toUnit.ToLower() == "gal")
                    return value * 0.000264172;
            }
            else if (fromUnit.ToLower() == "gal")
            {
                if (toUnit.ToLower() == "l")
                    return value * 3.78541;
                else if (toUnit.ToLower() == "ml")
                    return value * 3785.41;
            }

            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            Console.WriteLine("Choose the conversion type:");
            Console.WriteLine("1. Length");
            Console.WriteLine("2. Weight");
            Console.WriteLine("3. Volume");
            int choice = int.Parse(Console.ReadLine());

            double value;
            string fromUnit, toUnit;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the value and the units of the initial length (Exemple: 5 m):");
                    value = double.Parse(Console.ReadLine());
                    fromUnit = Console.ReadLine();
                    Console.WriteLine("Enter the units to convert to (Exemple: cm):");
                    toUnit = Console.ReadLine();
                    Console.WriteLine("Conversion result: " + converter.LengthConverter(value, fromUnit, toUnit) + " " + toUnit);
                    break;
                case 2:
                    Console.WriteLine("Enter the value and the units of the initial weight (Exemple: 5 kg):");
                    value = double.Parse(Console.ReadLine());
                    fromUnit = Console.ReadLine();
                    Console.WriteLine("Enter the units to convert to (Exemple:  g):");
                    toUnit = Console.ReadLine();
                    Console.WriteLine("Conversion result: " + converter.WeightConverter(value, fromUnit, toUnit) + " " + toUnit);
                    break;
                case 3:
                    Console.WriteLine("Enter the value and the units of the initial volume (Exemple: 5 l):");
                    value = double.Parse(Console.ReadLine());
                    fromUnit = Console.ReadLine();
                    Console.WriteLine("Enter the units to convert to (Exemple: gal):");
                    toUnit = Console.ReadLine();
                    Console.WriteLine("Conversion result: " + converter.VolumeConverter(value, fromUnit, toUnit) + " " + toUnit);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}