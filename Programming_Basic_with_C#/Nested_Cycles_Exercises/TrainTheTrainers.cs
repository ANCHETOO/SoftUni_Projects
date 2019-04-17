using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double averageMark = 0;
            int counter = 0;

            while (comand != "Finish")
            {
                string name = comand;
                double averageName = 0;

                for (int i = 1; i <= n; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    averageName += mark;
                }

                averageName = (averageName * 1.0) / (1.0 * n);
                averageMark += averageName;
                counter += 1;
                Console.WriteLine($"{name} - {averageName:f2}.");
                comand = Console.ReadLine();
            }

            averageMark = (averageMark * 1.0) / (counter * 1.0);
            Console.WriteLine($"Student's final assessment is {averageMark:f2}.");
        }
    }
}
