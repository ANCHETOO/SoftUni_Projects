using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var car = new Car
                {
                    Model = input[0],
                    Fuel = double.Parse(input[1]),
                    FuelConsumptionPerKm = double.Parse(input[2])
                };
                list.Add(car);
            }

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] drive = comand.Split(' ');
                var car = list.Find(x => x.Model == drive[1]);
                double fuelForDrive = car.FuelConsumptionPerKm * double.Parse(drive[2]);

                if (fuelForDrive > car.Fuel)
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
                else
                {
                    car.Fuel -= fuelForDrive;
                    car.TraveledDistance += double.Parse(drive[2]);
                }

                comand = Console.ReadLine();
            }

            foreach (var car in list)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TraveledDistance}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TraveledDistance { get; set; }
    }
}

