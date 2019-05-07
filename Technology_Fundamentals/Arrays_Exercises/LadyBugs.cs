using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] index = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var item in index)
            {
                if (item >= 0 && item < arr.Length)
                {
                    arr[item] = 1;
                }
            }

            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] flight = comand.Split(' ').ToArray();
                int start = int.Parse(flight[0]);
                int step = int.Parse(flight[2]);
                string direction = flight[1];

                if (direction == "left")
                {
                    step *= -1;
                }

                if (step != 0)
                {
                    if (start >= 0 && start < arr.Length)
                    {
                        if (arr[start] == 1)
                        {
                            int end = start + step;

                            if (end < 0 || end >= arr.Length)
                            {
                                arr[start] = 0;
                            }
                            else if (end >= 0 && end < arr.Length)
                            {
                                arr[start] = 0;

                                while (arr[end] != 0)
                                {
                                    end += step;

                                    if (end < 0 || end >= arr.Length)
                                    {
                                        break;
                                    }
                                }

                                if (end >= 0 && end < arr.Length)
                                {
                                    arr[end] = 1;
                                }
                            }

                        }
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}

