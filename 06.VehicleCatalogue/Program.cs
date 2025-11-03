using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            string capitalizedType = char.ToUpper(Type[0]) + Type.Substring(1);
            return $"Type: {capitalizedType}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                string type = parts[0];
                string model = parts[1];
                string color = parts[2];
                int horsepower = int.Parse(parts[3]);

                vehicles.Add(new Vehicle(type, model, color, horsepower));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == input);
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle);
                }
            }

            var cars = vehicles.Where(v => v.Type == "car").ToList();
            var trucks = vehicles.Where(v => v.Type == "truck").ToList();

            double avgCarHp = cars.Count > 0 ? cars.Average(c => c.Horsepower) : 0;
            double avgTruckHp = trucks.Count > 0 ? trucks.Average(t => t.Horsepower) : 0;

            Console.WriteLine($"Cars have average horsepower of: {avgCarHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:F2}.");
        }
    }
}
