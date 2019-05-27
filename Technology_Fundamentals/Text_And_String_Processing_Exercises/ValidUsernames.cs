using System;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool IsValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if ((char.IsDigit(username[i]) == true)
                            || (char.IsLetter(username[i]) == true)
                            || (username[i] == '-')
                            || (username[i] == '_'))
                        {
                            continue;
                        }
                        else
                        {
                            IsValid = false;
                            break;
                        }
                    }

                    if (IsValid == true)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
