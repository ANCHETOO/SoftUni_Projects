using System;
using System.Collections;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiplier = int.Parse(Console.ReadLine());
            int toAdd = 0;
            var stack = new Stack();

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int lastDigid = int.Parse(number[i].ToString());
                string result = (lastDigid * multiplier + toAdd).ToString();

                if (result.Length > 1)
                {
                    stack.Push(result[1]);
                    toAdd = int.Parse(result[0].ToString());
                }
                else
                {
                    stack.Push(result[0]);
                    toAdd = 0;
                }
            }

            if (toAdd != 0)
            {
                stack.Push(toAdd);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}

