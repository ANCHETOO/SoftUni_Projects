using System;

namespace sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsFirst = int.Parse(Console.ReadLine());   //1..50
            int secondsSecond = int.Parse(Console.ReadLine());  //1..50
            int secondsThird = int.Parse(Console.ReadLine());   //1..50

            int seconds = secondsFirst + secondsSecond + secondsThird;
            int minutes = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
