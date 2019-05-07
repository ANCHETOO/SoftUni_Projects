using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            string dna = command;
            int sum = 0;
            int counterCommands = 0;
            int index = 1;
            int counter = 1;
            int sample = 1;

            while (command != "Clone them!")
            {
                counterCommands++;
                string[] arr = command.Split('!', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == "1")
                    {
                        int currCounter = 1;

                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                int currIndex = i;
                                currCounter++;

                                if (currCounter > counter)
                                {
                                    counter = currCounter;
                                    index = currIndex;
                                    dna = command;
                                    sample = counterCommands;
                                }
                                else if (currCounter == counter)
                                {
                                    if (index > i)
                                    {
                                        index = i;
                                        dna = command;
                                        sample = counterCommands;
                                    }
                                    else if (index == i)
                                    {
                                        int currSum = 0;
                                        sum = 0;
                                        string[] dnaM = dna.Split('!', StringSplitOptions.RemoveEmptyEntries);

                                        for (int m = 0; m < arr.Length; m++)
                                        {
                                            currSum += int.Parse(arr[m]);
                                            sum += int.Parse(dnaM[m].ToString());
                                        }

                                        if (sum < currSum)
                                        {
                                            dna = command;
                                            sample = counterCommands;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            sum = 0;
            string[] result = dna.Split('!', StringSplitOptions.RemoveEmptyEntries);

            for (int l = 0; l < result.Length; l++)
            {
                sum += int.Parse(result[l].ToString());
            }

            Console.WriteLine($"Best DNA sample {sample} with sum: {sum}.");
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
