using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Simple_Text_Editor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (line[0])
                {
                    case "1":
                        {
                            string strToAdd = line[1];
                            result = result + strToAdd;
                            stack.Push(result);
                            break;
                        }
                    case "2":
                        {
                            int countToBeErased = int.Parse(line[1]);

                            if (countToBeErased < result.Length && countToBeErased > 0)
                            {
                                result = result.Substring(0, result.Length - countToBeErased);
                                stack.Push(result);
                            }
                            else if (countToBeErased >= result.Length)
                            {
                                result = string.Empty;
                                stack.Push(result);
                            }

                            break;
                        }
                    case "3":
                        {
                            int index = int.Parse(line[1]) - 1;

                            if (index >= 0 && index < result.Length)
                            {
                                Console.WriteLine(result[index]);
                            }

                            break;
                        }
                    case "4":
                        {
                            if (stack.Count >= 2)
                            {
                                stack.Pop();
                                result = stack.Peek();
                            }
                            else
                            {
                                result = string.Empty;
                                stack.Clear();
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
