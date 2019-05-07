using System;

namespace Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 0; i < lenght; i++)
            {
                string comand = Console.ReadLine();
                int count = comand.Length;
                int number = int.Parse(comand[0].ToString());
                char button = ' ';

                switch (number)
                {
                    case 0:
                        {
                            break;
                        }
                    case 2:
                        {
                            if (count == 1)
                            {
                                button = 'a';
                            }
                            else if (count == 2)
                            {
                                button = 'b';
                            }
                            else
                            {
                                button = 'c';
                            }
                            break;
                        }
                    case 3:
                        {
                            if (count == 1)
                            {
                                button = 'd';
                            }
                            else if (count == 2)
                            {
                                button = 'e';
                            }
                            else
                            {
                                button = 'f';
                            }
                            break;
                        }
                    case 4:
                        {
                            if (count == 1)
                            {
                                button = 'g';
                            }
                            else if (count == 2)
                            {
                                button = 'h';
                            }
                            else
                            {
                                button = 'i';
                            }
                            break;
                        }
                    case 5:
                        {
                            if (count == 1)
                            {
                                button = 'j';
                            }
                            else if (count == 2)
                            {
                                button = 'k';
                            }
                            else
                            {
                                button = 'l';
                            }
                            break;
                        }
                    case 6:
                        {
                            if (count == 1)
                            {
                                button = 'm';
                            }
                            else if (count == 2)
                            {
                                button = 'n';
                            }
                            else
                            {
                                button = 'o';
                            }
                            break;
                        }
                    case 7:
                        {
                            if (count == 1)
                            {
                                button = 'p';
                            }
                            else if (count == 2)
                            {
                                button = 'q';
                            }
                            else if (count == 3)
                            {
                                button = 'r';
                            }
                            else
                            {
                                button = 's';

                            }
                            break;
                        }
                    case 8:
                        if (count == 1)
                        {
                            button = 't';
                        }
                        else if (count == 2)
                        {
                            button = 'u';
                        }
                        else
                        {
                            button = 'v';
                        }
                        break;
                    case 9:
                        if (count == 1)
                        {
                            button = 'w';
                        }
                        else if (count == 2)
                        {
                            button = 'x';
                        }
                        else if (count == 3)
                        {
                            button = 'y';
                        }
                        else
                        {
                            button = 'z';
                        }
                        break;
                    default:
                        break;
                }

                output += button;
            }

            Console.WriteLine(output);
        }
    }
}
