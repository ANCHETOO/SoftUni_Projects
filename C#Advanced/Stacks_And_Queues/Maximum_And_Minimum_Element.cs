using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_And_Minimum_Element
{
    class Maximum_And_Minimum_Element
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions
                    .RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                int number = line[0];

                switch (number)
                {
                    case 1:
                        {
                            for (int j = 1; j < line.Length; j++)
                            {
                                stack.Push(line[j]);
                            }

                            break;
                        }
                    case 2:
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    case 3:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Max());
                            }

                            break;
                        }

                    case 4:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Min());
                            }

                            break;
                        }
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
