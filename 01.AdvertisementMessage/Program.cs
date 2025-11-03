using System;

namespace _01.AdvertisementMessage
{
    class AdvertisementMessageGenerator
    {
        static void Main()
        {
            string[] phrases = {
            "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can't live without this product."
        };

            string[] events = {
            "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"
        };

            string[] authors = {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

            string[] cities = {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };


            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rand.Next(phrases.Length)];
                string eventText = events[rand.Next(events.Length)];
                string author = authors[rand.Next(authors.Length)];
                string city = cities[rand.Next(cities.Length)];

                Console.WriteLine($"{phrase} {eventText} {author} – {city}.");
            }
        }
    }


}
