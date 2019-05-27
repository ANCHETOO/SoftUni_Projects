using System;

namespace DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    {
                        Console.WriteLine(ModifyInput(int.Parse(Console.ReadLine())));
                        break;
                    }
                case "real":
                    {
                        Console.WriteLine(ModifyInput(double.Parse(Console.ReadLine())));
                        break;
                    }
                case "string":
                    {
                        Console.WriteLine(ModifyInput(Console.ReadLine()));
                        break;
                    }
                default:
                    break;
            }
        }

        public static string ModifyInput(int num) => (2 * num).ToString();

        public static string ModifyInput(double num) => string.Format("{0:f2}", 1.5 * num);

        public static string ModifyInput(string str)
        {
            string result = "$";
            result += str + "$";
            return result;
        }
    }
}
