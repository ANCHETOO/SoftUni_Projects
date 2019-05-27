using System;
using System.Linq;
using System.Collections.Generic;

namespace Miner
{
    class Miner
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var matrix = new char[size, size];
            int x = 0;
            int y = 0;
            int count = 0;
            int coals = 0;

            for (int i = 0; i < size; i++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = line[j];

                    if (matrix[i, j] == 's')
                    {
                        x = i;
                        y = j;
                    }

                    if (matrix[i, j] == 'c')
                    {
                        count++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string curr = commands[i];

                switch (curr)
                {
                    case "right":
                        {
                            if (y + 1 < size)
                            {
                                y = y + 1;
                            }

                            break;
                        }
                    case "left":
                        {
                            if (y - 1 >= 0)
                            {
                                y = y - 1;
                            }

                            break;
                        }
                    case "up":
                        {
                            if (x - 1 >= 0)
                            {
                                x = x - 1;
                            }

                            break;
                        }
                    case "down":
                        {
                            if (x + 1 < size)
                            {
                                x = x + 1;
                            }

                            break;
                        }
                    default:
                        break;
                }

                if (matrix[x, y] == 'c')
                {
                    coals++;
                    matrix[x, y] = '*';

                    if (coals == count)
                    {
                        Console.WriteLine($"You collected all coals! ({x}, {y})");
                        return;
                    }
                }

                if (matrix[x, y] == 'e')
                {
                    Console.WriteLine($"Game over! ({x}, {y})");
                    return;
                }
            }

            Console.WriteLine($"{count - coals} coals left. ({x}, {y})");
        }
    }
}
