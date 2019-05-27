using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), input[4]);
                list.Add(car);
            }

            string typeToPrint = Console.ReadLine();

            if (typeToPrint == "fragile")
            {
                foreach (var car in list)
                {
                    if (car.Cargo.Type == typeToPrint)
                    {
                        if (car.Cargo.Weight < 1000)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }

            }
            else
            {
                foreach (var car in list)
                {
                    if (car.Cargo.Type == typeToPrint)
                    {
                        if (car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model, double speed, double power, double weight, string type)
        {
            Engine = new Engine();
            Cargo = new Cargo();

            this.Model = model;
            this.Engine.Power = power;
            this.Engine.Speed = speed;
            this.Cargo.Weight = weight;
            this.Cargo.Type = type;
        }
    }

    public class Engine
    {
        public double Speed { get; set; }

        public double Power { get; set; }
    }

    public class Cargo
    {
        public double Weight { get; set; }

        public string Type { get; set; }
    }
}
