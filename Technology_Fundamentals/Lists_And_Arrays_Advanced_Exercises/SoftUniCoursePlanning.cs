using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine()
                .Split(", ")
                .ToList();
            string comand = Console.ReadLine();
            List<string> exercise = new List<string>();

            while (comand != "course start")
            {
                string[] arr = comand.Split(':').ToArray();
                string name = arr[0];

                switch (name)
                {
                    case "Add":
                        {
                            string lesson = arr[1];

                            if (!course.Contains(lesson))
                            {
                                course.Add(lesson);
                            }

                            break;
                        }
                    case "Insert":
                        {
                            string lesson = arr[1];
                            int index = int.Parse(arr[2]);

                            if (!course.Contains(lesson))
                            {
                                course.Insert(index, lesson);
                            }

                            break;
                        }
                    case "Remove":
                        {
                            string lesson = arr[1];

                            if (course.Contains(lesson))
                            {
                                course.Remove(lesson);
                            }

                            break;
                        }
                    case "Swap":
                        {
                            string lesson1 = arr[1];
                            string lesson2 = arr[2];

                            if (course.Contains(lesson1) && course.Contains(lesson2))
                            {
                                int index1 = course.IndexOf(lesson1);
                                int index2 = course.IndexOf(lesson2);
                                string min = course[Math.Min(index1, index2)];
                                string max = course[Math.Max(index1, index2)];
                                course[Math.Min(index1, index2)] = max;
                                course[Math.Max(index1, index2)] = min;
                            }

                            break;

                        }
                    case "Exercise":
                        {
                            string lesson = arr[1];

                            if (!course.Contains(lesson))
                            {
                                course.Add(lesson);
                                exercise.Add(lesson);
                            }
                            else
                            {
                                if (!exercise.Contains(lesson))
                                {
                                    exercise.Add(lesson);
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }

                comand = Console.ReadLine();
            }

            PrintCourse(course, exercise);
        }

        public static void PrintCourse(List<string> course, List<string> exercise)
        {
            int counter = 1;

            for (int i = 0; i < course.Count; i++)
            {
                Console.Write($"{counter}.");
                Console.WriteLine(course[i]);
                counter++;

                if (exercise.Contains(course[i]))
                {
                    Console.Write($"{counter}.");
                    Console.WriteLine(course[i] + "-" + "Exercise");
                    counter++;
                }
            }
        }
    }
}
