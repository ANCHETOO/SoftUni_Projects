using System;

namespace Exam_Pep
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double mark = 0;
            double sum = 0;
            string lastProblem = string.Empty;
            int counter = 0;
            int badMarkCounter = 0;

            while (comand != "Enough")
            {
                lastProblem = comand;
                mark = double.Parse(Console.ReadLine());
                sum += mark;
                counter++;

                if (mark <= 4)
                {
                    badMarkCounter++;

                    if (badMarkCounter == poorGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        return;
                    }
                }

                comand = Console.ReadLine();
            }

            sum = sum / counter * 1.0;

            Console.WriteLine($"Average score: {sum:f2}");
            Console.WriteLine($"Number of problems: {counter}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
