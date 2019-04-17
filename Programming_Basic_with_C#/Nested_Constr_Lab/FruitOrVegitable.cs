using System;

namespace Fruit_Of_Vegitable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output;

            if (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
            {
                output = "fruit";
            }
            else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
            {
                output = "vegetable";
            }
            else
            {
                output = "unknown";
            }

            Console.WriteLine(output);
        }
    }
}
