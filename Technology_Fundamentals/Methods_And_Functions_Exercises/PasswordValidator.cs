using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (Is10charecter(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (IsLetterOrDigid(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (IsContain2Digid(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if ((Is10charecter(password) == true) && (IsLetterOrDigid(password) == true) && (IsContain2Digid(password) == true))
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool Is10charecter(string password)
        {
            bool result = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                result = true;
            }

            return result;
        }

        static bool IsLetterOrDigid(string password)
        {
            bool result = true;

            for (int i = 0; i < password.Length; i++)
            {
                if ((Char.IsLetter(password[i]) == false) && (Char.IsDigit(password[i]) == false))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static bool IsContain2Digid(string password)
        {
            bool result = false;
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]) == true)
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                result = true;
            }

            return result;
        }
    }
}
