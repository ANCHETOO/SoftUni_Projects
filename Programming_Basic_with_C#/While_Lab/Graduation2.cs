using System;

namespace Graduation
{
    class Graduation2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            double sum = 0;

            while (counter < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark >= 4)
                {
                    sum += mark;
                    counter++;
                }
                else
                {
                    double popravka = double.Parse(Console.ReadLine());

                    if (popravka >= 4)
                    {
                        sum += mark;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (counter == 12)
            {
                sum = sum / 12.0;
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter + 1} grade");
            }
        }
    }
}

