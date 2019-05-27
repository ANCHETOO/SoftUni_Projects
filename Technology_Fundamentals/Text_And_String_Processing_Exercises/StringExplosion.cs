using System;
using System.Text;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];

                if (curr == '>')
                {
                    if (count == 0)
                    {
                        sb.Append(curr);

                        if (i + 1 < input.Length)
                        {
                            count = int.Parse(input[i + 1].ToString());
                        }
                    }
                    else if (count != 0)
                    {
                        sb.Append(curr);

                        if (i + 1 < input.Length)
                        {
                            count += int.Parse(input[i + 1].ToString());
                        }
                    }
                }
                else if (curr != '>')
                {
                    if (count == 0)
                    {
                        sb.Append(curr);
                    }
                    else if (count != 0)
                    {
                        count--;
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
