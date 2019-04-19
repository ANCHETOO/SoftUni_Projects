using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());

            if (numFirst >= numSecond)
            {
                Console.WriteLine(numFirst);
            }
            else
            {
                Console.WriteLine(numSecond);
            }
        }
    }
}
