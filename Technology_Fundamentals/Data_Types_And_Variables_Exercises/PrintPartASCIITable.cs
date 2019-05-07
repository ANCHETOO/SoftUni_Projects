using System;

namespace Print_Part_ASCII_Table
{
    class PrintPartASCIITable
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                start = start + end;
                end = start - end;
                start = start - end;
            }

            for (int i = start; i <= end; i++)
            {
                char letter = (char)i;
                Console.Write(letter + " ");
            }

            Console.WriteLine();
        }
    }
}
