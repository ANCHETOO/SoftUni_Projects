using System;
using System.Numerics;

namespace Data_Type_Finder
{
    class DataTypeFinder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {

                if (BigInteger.TryParse(input, out BigInteger resultInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out float resultFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char resultChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool resultBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
