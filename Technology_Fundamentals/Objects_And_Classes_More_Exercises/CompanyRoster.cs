using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<Emplyee>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                var employee = new Emplyee(name, salary, department);

                if (!dictionary.ContainsKey(department))
                {
                    dictionary.Add(department, new List<Emplyee>());
                    dictionary[department].Add(employee);
                }
                else if (dictionary.ContainsKey(department))
                {
                    dictionary[department].Add(employee);
                }
            }

            string maxAvarageSalaryKey = string.Empty;
            double maxAverageSalary = double.MinValue;

            foreach (var kvp in dictionary)
            {
                double avarageSalary = 0;

                foreach (var emplyee in dictionary[kvp.Key])
                {
                    avarageSalary += emplyee.Salary;
                }

                avarageSalary = avarageSalary / dictionary[kvp.Key].Count;

                if (maxAverageSalary < avarageSalary)
                {
                    maxAverageSalary = avarageSalary;
                    maxAvarageSalaryKey = kvp.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {maxAvarageSalaryKey}");
            var list = dictionary[maxAvarageSalaryKey];
            var newList = list.OrderByDescending(x => x.Salary).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }

    class Emplyee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

        public Emplyee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }
}
