using System;
using System.Numerics;

namespace Integer_Operation
{
    class IntegerOperation
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            BigInteger fourthNum = BigInteger.Parse(Console.ReadLine());
            BigInteger result = firstNum + secondNum;

            if (thirdNum != 0)
            {
                result = result / thirdNum;
                result *= fourthNum;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Division by zero is not possible!");
            }
        }
    }
}
