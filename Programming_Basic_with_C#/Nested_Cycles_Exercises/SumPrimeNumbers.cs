using System;
using System.Numerics;


namespace Sum_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            BigInteger sumPrime = 0;
            BigInteger sumNotprime = 0;

            while (comand != "stop")
            {
                BigInteger current = BigInteger.Parse(comand);

                if (current < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    if (IsPrime(current))
                    {
                        sumPrime += current;
                    }
                    else
                    {
                        sumNotprime += current;
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotprime}");
        }

        static bool IsPrime(BigInteger number)
        {
            bool result = true;

            if (number == 0)
            {
                result = false;
            }

            if (number == 1)
            {
                result = false;
            }

            if (number == 2)
            {
                result = true;
            }

            if (number > 2)
            {
                for (BigInteger i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
