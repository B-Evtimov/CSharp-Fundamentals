using System;
using System.Collections.Generic;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<song> songs = new List<song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                song Song = new song();
                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song.TypeList = type;
                Song.Name = name;
                Song.Time = time;

                songs.Add(Song);
            }
            string TypeList = Console.ReadLine();
            if (TypeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }


        }
    }

    public class song
    {

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
