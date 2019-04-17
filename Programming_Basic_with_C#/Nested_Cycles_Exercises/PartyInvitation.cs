using System;
using System.Text.RegularExpressions;

namespace Party_Invitation
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int counter = 0;
            double validNames = 0;
            double invalidNames = 0;
            int counterValid = 0;


            while (comand != "Statistic")
            {
                string name = comand;
                counter++;

                if (!IsRight(name))
                {
                    Console.WriteLine("Invalid name!");
                }
                else
                {
                    name = name.ToLower();
                    string rightName = name[0].ToString().ToUpper();

                    for (int i = 1; i < name.Length; i++)
                    {
                        rightName += name[i];
                    }

                    Console.WriteLine(rightName);
                    counterValid++;
                }

                comand = Console.ReadLine();
            }

            validNames = (counterValid * 1.0) / (counter * 1.0) * 100;
            invalidNames = 100 - validNames;

            Console.WriteLine($"Valid names are {validNames:f2}% from {counter} names.");
            Console.WriteLine($"Invalid names are {invalidNames:f2}% from {counter} names.");

        }

        static bool IsRight(string name)
        {
            bool result = true;
            Regex pattern = new Regex("[^a-zA-Z]");
            Match match = pattern.Match(name);

            if (match.Success)
            {
                result = false;
            }

            return result;
        }
    }
}
