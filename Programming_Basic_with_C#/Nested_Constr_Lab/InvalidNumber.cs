using System;

namespace Invalid_Nimber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool validNumber;

            if ((number == 0) || (number >= 100 && number <= 200))
            {
                validNumber = true;
            }
            else
            {
                validNumber = false;
                Console.WriteLine("invalid");
            }
        }
    }
}
