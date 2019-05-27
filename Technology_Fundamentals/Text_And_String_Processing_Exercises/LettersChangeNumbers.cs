using System;
using System.Text;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var curr = new StringBuilder();
                curr.Append(input[i]);
                char first = curr[0];
                char last = curr[curr.Length - 1];
                curr = curr.Remove(0, 1);
                curr = curr.Remove(curr.Length - 1, 1);
                decimal num = decimal.Parse(curr.ToString());

                if (char.IsUpper(first) == true)
                {
                    num = num / ((decimal)((int)(first) - 64));
                }
                else
                {
                    num = num * ((decimal)((int)(first) - 96));
                }

                if (char.IsUpper(last) == true)
                {
                    num = num - ((decimal)((int)(last) - 64));
                }
                else
                {
                    num = num + ((decimal)((int)(last) - 96));
                }

                sum += num;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
