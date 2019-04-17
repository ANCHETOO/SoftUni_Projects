using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(DayOfWeek.Monday);
                    break;
                case 2:
                    Console.WriteLine(DayOfWeek.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(DayOfWeek.Wednesday);
                    break;
                    case 4:
                    Console.WriteLine(DayOfWeek.Thursday);
                    break;
                case 5:
                    Console.WriteLine(DayOfWeek.Friday);
                    break;
                case 6:
                    Console.WriteLine(DayOfWeek.Saturday);
                    break;
                    case 7:
                    Console.WriteLine(DayOfWeek.Sunday);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
