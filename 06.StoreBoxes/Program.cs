using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox => Item.Price * ItemQuantity;
    }

    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = parts[0];
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3], CultureInfo.InvariantCulture);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item { Name = itemName, Price = itemPrice },
                    ItemQuantity = itemQuantity
                };

                boxes.Add(box);
            }

            foreach (var box in boxes.OrderByDescending(b => b.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}
