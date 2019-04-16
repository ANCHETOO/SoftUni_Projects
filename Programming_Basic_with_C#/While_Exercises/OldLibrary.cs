using System;

namespace Old_Library
{
    class OldLibrary
    {
        static void Main(string[] args)
        {
            string nameBook = Console.ReadLine();
            int countBook = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= countBook; i++)
            {
                string checkedBook = Console.ReadLine();

                if (checkedBook==nameBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}
