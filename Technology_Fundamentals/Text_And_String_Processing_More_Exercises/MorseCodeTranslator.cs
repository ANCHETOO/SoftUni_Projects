using System;
using System.Text;

namespace MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char ch = '?';

                if (curr == ".-")
                {
                    ch = 'A';
                }
                else if (curr == "-...")
                {
                    ch = 'B';
                }
                else if (curr == "-.-.")
                {
                    ch = 'C';
                }
                else if (curr == "-..")
                {
                    ch = 'D';
                }
                else if (curr == ".")
                {
                    ch = 'E';
                }
                else if (curr == "..-.")
                {
                    ch = 'F';
                }
                else if (curr == "--.")
                {
                    ch = 'G';
                }
                else if (curr == "....")
                {
                    ch = 'H';
                }
                else if (curr == "..")
                {
                    ch = 'I';
                }
                else if (curr == ".---")
                {
                    ch = 'J';
                }
                else if (curr == "-.-")
                {
                    ch = 'K';
                }
                else if (curr == ".-..")
                {
                    ch = 'L';
                }
                else if (curr == "--")
                {
                    ch = 'M';
                }
                else if (curr == "-.")
                {
                    ch = 'N';
                }
                else if (curr == "---")
                {
                    ch = 'O';
                }
                else if (curr == ".--.")
                {
                    ch = 'P';
                }
                else if (curr == "--.-")
                {
                    ch = 'Q';
                }
                else if (curr == ".-.")
                {
                    ch = 'R';
                }
                else if (curr == "...")
                {
                    ch = 'S';
                }
                else if (curr == "-")
                {
                    ch = 'T';
                }
                else if (curr == "..-")
                {
                    ch = 'U';
                }
                else if (curr == "...-")
                {
                    ch = 'V';
                }
                else if (curr == ".--")
                {
                    ch = 'W';
                }
                else if (curr == "-..-")
                {
                    ch = 'X';
                }
                else if (curr == "-.--")
                {
                    ch = 'Y';
                }
                else if (curr == "--..")
                {
                    ch = 'Z';
                }
                else if (curr == "|")
                {
                    ch = ' ';
                }

                sb.Append(ch);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
