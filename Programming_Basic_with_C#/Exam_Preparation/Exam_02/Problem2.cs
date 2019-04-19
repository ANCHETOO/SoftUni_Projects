using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double sideBar = double.Parse(Console.ReadLine());

            double hall = width * lenght;
            double dancingPlace = 0.19 * hall;
            double freeSpace = hall - dancingPlace - sideBar * sideBar;
            int count = (int)(Math.Ceiling(freeSpace / 3.2));

            Console.WriteLine(count);
        }
    }
}
