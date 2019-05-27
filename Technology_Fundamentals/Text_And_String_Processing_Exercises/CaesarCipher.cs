using System;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                ch = (char)((int)ch + 3);
                sb.Append(ch);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

