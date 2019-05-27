using System;
using System.Linq;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    class OldestFamilyMember
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var person = new Person
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };
                family.AddMember(person);
            }

            var result = family.GetOldestMember();
            Console.WriteLine($"{result.Name} {result.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> ListOfPeople { get; set; }

        public Family()
        {
            ListOfPeople = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.ListOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {

            return ListOfPeople.Find(x => x.Age == ListOfPeople.Max(y => y.Age));
        }
    }
}
