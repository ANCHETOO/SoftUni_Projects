using System;
using System.Linq;

namespace Max_Sequence_Of_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = 0;
            int counter = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currElement = arr[i];
                int currCounter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currElement == arr[j])
                    {
                        currCounter++;

                        if (currCounter > counter)
                        {
                            counter = currCounter;
                            element = currElement;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int k = 0; k < counter; k++)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
