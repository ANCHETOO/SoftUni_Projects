using System;

namespace Area_Figurs
{
    class AreaFigurs
    {
        static void Main(string[] args)
        {
            string figur = Console.ReadLine();
            double area = 0.0;

            switch (figur)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        area = a * a;
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        area = a * b;
                        break;
                    }
                case "circle":
                    {
                        double r = double.Parse(Console.ReadLine());
                        area = Math.PI * r * r;
                        break;
                    }
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        area = a * h / 2.0;
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
