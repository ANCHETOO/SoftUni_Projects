using System;

namespace Sequense_2k_1
{
    class Sequence
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sequenceNumber = 1;

            while (number>=sequenceNumber)
            {
                Console.WriteLine(sequenceNumber);
                sequenceNumber = 2 * sequenceNumber + 1;
            }
        }
    }
}
