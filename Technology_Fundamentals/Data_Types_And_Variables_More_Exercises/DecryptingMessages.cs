using System;

namespace Decrypting_Messages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                char modified = (char)(letter + key);
                result += modified.ToString();
            }

            Console.WriteLine(result);
        }
    }
}
