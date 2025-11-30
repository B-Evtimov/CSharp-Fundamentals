using System;
using System.Collections.Generic;
using System.Linq;
/*Like-Krisi-shrimps
Like-Krisi-soup
Like-Penelope-dessert
Like-Misho-salad
Stop
*/
namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMealsCount = 0;

            string input;
            while ((input = Console.ReadLine()) != "Stop")

            {

                string[] parts = input.Split("-");
                string comad = parts[0];
                string name = parts[1];
                string product = parts[2];



                if (comad == "Like")
                {
                    if (!guests.ContainsKey(name))
                    {
                        guests[name] = new List<string>();
                    }


                    if (!guests[name].Contains(product))
                    {

                        guests[name].Add(product);



                    }


                }
                else if (comad == "Dislike")

                {
                    if (!guests.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");


                    }



                    else if (!guests[name].Contains(product))
                    {



                        Console.WriteLine($"{name} doesn't have the {product} in his/her collection.");
                    }





                    else
                    {
                        guests[name].Remove(product);

                        unlikedMealsCount++;

                        Console.WriteLine($"{name} doesn't like the {product}.");

                    }
                }
            }

            foreach (var kvp in guests)
            {

                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }


            Console.WriteLine($"Unliked meals: {unlikedMealsCount}");
        }
    }
}
