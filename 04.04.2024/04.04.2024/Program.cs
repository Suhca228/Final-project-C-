using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Конвертер одиниць виміру:
//Створіть клас Converter для реалізації конвертації між різними одиницями виміру (наприклад, довжина, вага, об'єм).
//Реалізуйте методи для конвертації значень з однієї одиниці в іншу.
//Користувач повинен ввести значення та одиниці вихідної величини, а потім вибрати одиниці, в які необхідно перевести.
//Результати конвертації виводяться на консоль.

namespace _04._04._2024
{
    interface IConverter
    {
        double Convert(double value, string fromUnit, string toUnit);
    }

    class LengthConverter : IConverter
    {
        public double Convert(double value, string fromUnit, string toUnit)
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
    }

    class WeightConverter : IConverter
    {
        public double Convert(double value, string fromUnit, string toUnit)
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
    }

    class VolumeConverter : IConverter
    {
        public double Convert(double value, string fromUnit, string toUnit)
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
            IConverter converter;

            Console.WriteLine("Choose the conversion type:");
            Console.WriteLine("1. Length");
            Console.WriteLine("2. Weight");
            Console.WriteLine("3. Volume");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    converter = new LengthConverter();
                    break;
                case 2:
                    converter = new WeightConverter();
                    break;
                case 3:
                    converter = new VolumeConverter();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Enter the value and the units of the initial measurement (Exemple: 5 m):");
            double value = double.Parse(Console.ReadLine());
            string fromUnit = Console.ReadLine();
            Console.WriteLine("Enter the units to convert to (Exemple: cm):");
            string toUnit = Console.ReadLine();
            Console.WriteLine("Conversion result: " + converter.Convert(value, fromUnit, toUnit) + " " + toUnit);
        }
    }
}