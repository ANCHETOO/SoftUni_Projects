using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double scholarshipMark = 0.0;
            double scholarshipSocial = 0.0;

            if (b <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                if (b < 5.5)
                {
                    if (a < c)
                    {
                        scholarshipSocial = 0.35 * c;
                        Console.WriteLine($"You get a Social scholarship {Math.Truncate(scholarshipSocial)} BGN");
                    }
                    else
                    {
                        Console.WriteLine("You cannot get a scholarship!");
                    }
                }
                else
                {
                    if (a < c)
                    {
                        scholarshipSocial = 0.35 * c;
                    }
                    scholarshipMark = 25 * b;

                    if (scholarshipSocial > scholarshipMark)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Truncate(scholarshipSocial)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Truncate(scholarshipMark)} BGN");
                    }
                }
            }
        }
    }
}
