using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Balanced_Parentheses
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var stack = new Stack<char>();
            stack.Push(line[0]);
            char prev = stack.Peek();

            for (int i = 1; i < line.Length; i++)
            {
                char ch = line[i];

                if (stack.Count > 0)
                {
                    prev = stack.Peek();

                    switch (prev)
                    {
                        case '{':
                            {
                                if (ch == '}')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(ch);
                                }

                                break;
                            }
                        case '[':
                            {
                                if (ch == ']')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(ch);
                                }

                                break;
                            }
                        case '(':
                            {
                                if (ch == ')')
                                {
                                    stack.Pop();
                                }
                                else
                                {
                                    stack.Push(ch);
                                }

                                break;
                            }
                        default:
                            {
                                stack.Push(ch);
                                break;
                            }
                    }
                }
                else
                {
                    stack.Push(ch);
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"NO");
            }
            else
            {
                Console.WriteLine($"YES");
            }
        }
    }
}
