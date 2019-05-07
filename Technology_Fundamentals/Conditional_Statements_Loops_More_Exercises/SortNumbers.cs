using System;
using System.Linq;
using System.Collections.Generic;
namespace Sort_Numbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var list = new List<double>(3);

            for (int i = 1; i <= 3; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            list = list.OrderByDescending(x => x).ToList();

            foreach (var num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
