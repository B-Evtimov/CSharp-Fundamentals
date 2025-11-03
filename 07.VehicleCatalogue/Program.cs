using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }

    class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split('/');
                string type = parts[0];
                string brand = parts[1];
                string model = parts[2];
                int value = int.Parse(parts[3]);

                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = value
                    };
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = value
                    };
                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
