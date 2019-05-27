using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] input = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string operation = input[0];

                switch (operation)
                {
                    case "Add":
                        {
                            int number = int.Parse(input[1]);
                            list.Add(number);
                            break;
                        }
                    case "Remove":
                        {
                            int index = int.Parse(input[1]);

                            if (index >= 0 && index < list.Count)
                            {
                                list.RemoveAt(index);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }

                            break;
                        }
                    case "Insert":
                        {
                            int number = int.Parse(input[1]);
                            int index = int.Parse(input[2]);

                            if (index >= 0 && index < list.Count)
                            {
                                list.Insert(index, number);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }

                            break;
                        }
                    case "Shift":
                        {
                            if (input[1] == "left")
                            {
                                int count = int.Parse(input[2]);
                                ShiftLeftList(count, list);
                            }
                            else if (input[1] == "right")
                            {
                                int count = int.Parse(input[2]);
                                ShiftRigthList(count, list);
                            }
                            break;
                        }
                    default:
                        break;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', list));
        }

        private static void ShiftRigthList(int count, List<int> list)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, temp);
            }
        }

        private static void ShiftLeftList(int count, List<int> list)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
        }
    }
}
