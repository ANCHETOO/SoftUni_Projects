using System;
using System.Linq;

namespace Loggin
{
    class Loggin
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                password += name[i];
            }

            int counter = 0;

            while (true)
            {
                string loggin = Console.ReadLine();

                if (loggin == password)
                {
                    Console.WriteLine($"User {name} logged in.");
                    break;
                }
                else
                {
                    if (counter == 3)
                    {
                        Console.WriteLine($"User {name} blocked!");
                        break;
                    }

                    Console.WriteLine($"Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}
