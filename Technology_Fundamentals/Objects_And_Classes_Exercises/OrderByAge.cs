using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class OrderByAge
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Person> list = new List<Person>();

            while (comand != "End")
            {
                string[] input = comand.Split(' ');
                var person = new Person
                {
                    Name = input[0],
                    ID = input[1],
                    Age = int.Parse(input[2])
                };
                list.Add(person);
                comand = Console.ReadLine();
            }

            list = list.OrderBy(x => x.Age).ToList();
            PrintList(list);
        }

        private static void PrintList(List<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

    }
}

