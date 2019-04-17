using System;

namespace On_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            minExam = minExam + hourExam * 60;
            min = min + hour * 60;

            if (min > minExam)
            {
                Console.WriteLine("Late");

                if (min - minExam > 59)
                {
                    hour = (min - minExam) / 60;
                    min = (min - minExam) % 60;
                    Console.WriteLine($"{hour}:{min:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{min - minExam} minutes after the start");
                }
            }
            else if (min <= minExam && (minExam - min) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{minExam - min} minutes before the start");
            }
            else if (min <= minExam && (minExam - min) > 30)
            {
                Console.WriteLine("Early");

                if ((minExam - min) > 59)
                {
                    hour = (minExam - min) / 60;
                    min = (minExam - min) % 60;
                    Console.WriteLine($"{hour}:{min:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minExam - min} minutes before the start");
                }
            }
        }
    }
}
