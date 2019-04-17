using System;

namespace Opp_Bet_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            char opp = char.Parse(Console.ReadLine());
            double result = 0;
            
            if (opp=='+')
            {
                if ((a+b)%2==0)
                {
                    Console.WriteLine($"{a} {opp} {b} = {a + b} - even");
                }
                else
                {
                    Console.WriteLine($"{a} {opp} {b} = {a + b} - odd");
                }
            }
            else if(opp=='-')
            {
                if ((a - b) % 2 == 0)
                {
                    Console.WriteLine($"{a} {opp} {b} = {a - b} - even");
                }
                else
                {
                    Console.WriteLine($"{a} {opp} {b} = {a - b} - odd");
                }
            }
            else if (opp=='*')
            {
                if ((a * b) % 2 == 0)
                {
                    Console.WriteLine($"{a} {opp} {b} = {a * b} - even");
                }
                else
                {
                    Console.WriteLine($"{a} {opp} {b} = {a * b} - odd");
                }
            }
            else if (opp=='%')
            {
                if (b!=0)
                {
                    Console.WriteLine($"{a} {opp} {b} = {a % b}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {a} by zero");
                }
            }
            else if (opp=='/')
            {
                if (b!=0)
                {
                    result = (a *1.0) / (b*1.0)  ;
                    Console.WriteLine($"{a} {opp} {b} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {a} by zero");
                }
            }
        }
    }
}
