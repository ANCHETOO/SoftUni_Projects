using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double course = 0.0;
            double numberConverted = number;

            switch (input)
            {
                case "m":
                    course = 1.0;
                    break;
                case "mm":
                    course = 1.0 / 1_000;
                    break;
                case "cm":
                    course = 1.0 / 100;
                    break;
                case "mi":
                    course = 1.0 / 0.000621371192;
                    break;
                case "in":
                    course = 1.0 / 39.3700787;
                    break;
                case "km":
                    course = 1.0 / 0.001;
                    break;
                case "ft":
                    course = 1.0 / 3.2808399;
                    break;
                case "yd":
                    course = 1.0 / 1.0936133;
                    break;
                default:
                    break;
            }

            numberConverted *= course;

            switch (output)
            {
                case "m":
                    course = 1;
                    break;
                case "mm":
                    course = 1_000;
                    break;
                case "cm":
                    course = 100;
                    break;
                case "mi":
                    course = 0.000621371192;
                    break;
                case "in":
                    course = 39.3700787;
                    break;
                case "km":
                    course = 0.001;
                    break;
                case "ft":
                    course = 3.2808399;
                    break;
                case "yd":
                    course = 1.0936133;
                    break;
                default:
                    break;
            }

            numberConverted *= course;
            Console.WriteLine(numberConverted);
        }
    }
}
