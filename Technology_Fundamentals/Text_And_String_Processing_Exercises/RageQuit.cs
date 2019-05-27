using System;
using System.Text;
using System.Linq;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsDigit(ch) == false)
                {
                    ch = char.ToUpper(ch);
                    sb.Append(ch);
                }
                else if (char.IsDigit(ch) == true)
                {
                    if (i + 1 < input.Length)
                    {
                        if (char.IsDigit(input[i + 1]) == false)
                        {
                            int count = int.Parse(ch.ToString());

                            for (int j = 1; j <= count; j++)
                            {
                                result.Append(sb.ToString());
                            }

                            sb = sb.Clear();
                        }
                        else if (char.IsDigit(input[i + 1]) == true)
                        {
                            string countAsString = input.Substring(i, 2);
                            int count = int.Parse(countAsString);

                            for (int j = 1; j <= count; j++)
                            {
                                result.Append(sb.ToString());
                            }

                            sb = sb.Clear();
                            i++;
                        }
                    }
                    else if (i + 1 >= input.Length)
                    {
                        int count = int.Parse(ch.ToString());

                        for (int j = 1; j <= count; j++)
                        {
                            result.Append(sb.ToString());
                        }

                        sb = sb.Clear();
                    }
                }
            }

            string unique = new String(result.ToString().Distinct().ToArray());
            Console.WriteLine($"Unique symbols used: {unique.Length}");
            Console.WriteLine(result);
        }
    }
}

