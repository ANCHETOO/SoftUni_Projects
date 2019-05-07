﻿using System;

namespace EnglishName
{
    class EnglishName
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digid = num % 10;

            PrintDigid(digid);
        }

        public static void PrintDigid(int digid)
        {
            string result = string.Empty;

            switch (digid)
            {
                case 0:
                    {
                        result = "zero";
                        break;
                    }
                case 1:
                    {
                        result = "one";
                        break;
                    }
                case 2:
                    {
                        result = "two";
                        break;
                    }
                case 3:
                    {
                        result = "three";
                        break;
                    }
                case 4:
                    {
                        result = "four";
                        break;
                    }
                case 5:
                    {
                        result = "five";
                        break;
                    }
                case 6:
                    {
                        result = "six";
                        break;
                    }
                case 7:
                    {
                        result = "seven";
                        break;
                    }
                case 8:
                    {
                        result = "eight";
                        break;
                    }
                case 9:
                    {
                        result = "nine";
                        break;
                    }
                default:
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
