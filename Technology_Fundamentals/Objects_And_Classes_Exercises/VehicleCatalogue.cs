using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Vehicle> list = new List<Vehicle>();

            while (comand != "End")
            {
                string[] input = comand.Split(' '); //truck Man red 200
                var vehicle = new Vehicle
                {
                    Type = input[0],
                    Model = input[1],
                    Color = input[2],
                    HorsePower = double.Parse(input[3])
                };
                list.Add(vehicle);
                comand = Console.ReadLine();
            }

            comand = Console.ReadLine();

            while (comand != "Close the Catalogue")
            {
                int index = GetIndexModel(comand, list);
                PrintNodelInfo(index, list);
                comand = Console.ReadLine();
            }

            double avarageCarHorsepower = 0;
            double avarageTruckHorsepower = 0;
            int carCounter = 0;
            int truckCounter = 0;
            double carSum = 0;
            double truckSum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Type == "car")
                {
                    carCounter++;
                    carSum += list[i].HorsePower;
                }
                else
                {
                    truckCounter++;
                    truckSum += list[i].HorsePower;
                }
            }

            if (carCounter != 0)
            {
                avarageCarHorsepower = carSum / (carCounter * 1.0);
            }

            if (truckCounter != 0)
            {
                avarageTruckHorsepower = truckSum / (truckCounter * 1.0);
            }

            Console.WriteLine($"Cars have average horsepower of: {avarageCarHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageTruckHorsepower:f2}.");
        }

        private static void PrintNodelInfo(int index, List<Vehicle> list)
        {
            if (list[index].Type == "car")
            {
                Console.WriteLine($"Type: Car");
            }
            else
            {
                Console.WriteLine($"Type: Truck");
            }

            Console.WriteLine($"Model: {list[index].Model}");
            Console.WriteLine($"Color: {list[index].Color}");
            Console.WriteLine($"Horsepower: {list[index].HorsePower}");
        }

        private static int GetIndexModel(string comand, List<Vehicle> list)
        {
            int result = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Model == comand)
                {
                    result = i;
                }
            }

            return result;
        }
    }

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

    }
}

