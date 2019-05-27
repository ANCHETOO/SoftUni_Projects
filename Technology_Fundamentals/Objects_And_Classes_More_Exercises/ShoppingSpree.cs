using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            var ProductList = new List<Product>();
            var PersonList = new List<Person>();
            string comand = Console.ReadLine();
            string[] input = comand.Split(';');

            for (int i = 0; i < input.Length; i++)
            {
                string[] modifiedInput = input[i].Split('=');
                var person = new Person(modifiedInput[0], double.Parse(modifiedInput[1]));
                PersonList.Add(person);
            }

            comand = Console.ReadLine();
            input = comand.Split(';');

            for (int j = 0; j < input.Length; j++)
            {
                string[] modifiedInput = input[j].Split('=');
                var product = new Product
                {
                    Name = modifiedInput[0],
                    Cost = double.Parse(modifiedInput[1])
                };
                ProductList.Add(product);
            }

            comand = Console.ReadLine();

            while (comand != "END")
            {
                input = comand.Split(' ');
                PersonList.Find(x => x.Name == input[0]).BuyProduct(ProductList.Find(y => y.Name == input[1]));
                comand = Console.ReadLine();
            }

            foreach (var person in PersonList)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.Write($"{person.Name} - ");

                    for (int i = 0; i < person.BagOfProducts.Count - 1; i++)
                    {
                        Console.Write($"{person.BagOfProducts[i].Name}, ");
                    }

                    Console.WriteLine($"{person.BagOfProducts[person.BagOfProducts.Count - 1].Name}");
                }
                else
                {

                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public double Money { get; set; }

        public List<Product> BagOfProducts { get; set; }

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (Money - product.Cost >= 0)
            {
                BagOfProducts.Add(product);
                this.Money = Money - product.Cost;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }

        public double Cost { get; set; }
    }
}
