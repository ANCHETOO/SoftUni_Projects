using System;

namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            while (comand != "END")
            {
                Console.WriteLine(IsPalindrom(comand).ToString().ToLower());
                comand = Console.ReadLine();
            }
        }

        public static bool IsPalindrom(string str)
        {
            string reverse = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            if (reverse.Equals(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
