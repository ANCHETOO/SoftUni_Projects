using System;

namespace Steps
{
    class Steps
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int steps = 0;

            while (comand!= "Going home")
            {
                steps += int.Parse(comand);

                if (steps>=10_000)
                {
                    break;
                }

                comand = Console.ReadLine();
            }

            if (comand== "Going home")
            {
                comand = Console.ReadLine();
                steps += int.Parse(comand);

                if (steps >= 10_000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10_000-steps} more steps to reach goal.");
                }
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
