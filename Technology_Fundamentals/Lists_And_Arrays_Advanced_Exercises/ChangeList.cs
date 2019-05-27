using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] arr = comand.Split(' ').ToArray();

                if (arr[0] == "Delete")
                {
                    if (numbers.Contains(int.Parse(arr[1])))
                    {
                        numbers.RemoveAll(element => element == int.Parse(arr[1]));
                    }
                }

                if (arr[0] == "Insert")
                {
                    numbers.Insert(int.Parse(arr[2]), int.Parse(arr[1]));
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
