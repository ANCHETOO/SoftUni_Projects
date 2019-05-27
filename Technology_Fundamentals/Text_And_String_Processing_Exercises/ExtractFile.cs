using System;

namespace ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var splitted = input.Split('\\');
            string fullFileName = splitted[splitted.Length - 1];
            string extension = fullFileName.Substring(fullFileName.LastIndexOf('.') + 1);
            string fileName = fullFileName.Substring(0, fullFileName.LastIndexOf('.'));

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}