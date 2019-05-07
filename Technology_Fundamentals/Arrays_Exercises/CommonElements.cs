using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            foreach (var item in arr2)
            {
                foreach (var element in arr1)
                {
                    if (item==element)
                    {
                        Console.Write(item);
                        Console.Write(" ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
