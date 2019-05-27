using System;

namespace PrintArray
{
    class PrintArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();
                int sumVowels = 0;
                int sumConsonants = 0;
                for (int j = 0; j < comand.Length; j++)
                {
                    char letter = comand[j];
                    if (letter == 'a' ||
                        letter == 'o' ||
                        letter == 'u' ||
                        letter == 'e' ||
                        letter == 'i' ||
                        letter == 'A' ||
                        letter == 'O' ||
                        letter == 'U' ||
                        letter == 'E' ||
                        letter == 'I')
                    {

                        sumVowels += letter * comand.Length;

                    }
                    else
                    {

                        sumConsonants += letter / comand.Length;
                    }
                }
                arr[i] = sumVowels + sumConsonants;

            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}