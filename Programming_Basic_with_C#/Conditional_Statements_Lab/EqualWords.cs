using System;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordFirst = Console.ReadLine().ToLower();
            string wordSecond = Console.ReadLine().ToLower();

            if (wordFirst==wordSecond)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
