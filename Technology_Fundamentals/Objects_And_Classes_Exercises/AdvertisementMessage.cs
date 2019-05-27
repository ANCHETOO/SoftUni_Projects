using System;
using System.Linq;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            var phrases = new List<string>
            {
               "Excellent product.",
               "Such a great product.",
               "I always use that product.",
               "Best product of its category.",
               "Exceptional product.",
               "I can’t live without this product."
            };
            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            var cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            var random = new Random();
            GetRandom(phrases, random);
            GetRandom(events, random);
            GetRandom(authors, random);
            GetRandom(cities, random);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var message = new Message
                {
                    Phrase = phrases[i],
                    Event = events[i],
                    Author = authors[i],
                    City = cities[i]
                };

                Console.WriteLine($"{message.Phrase} {message.Event} {message.Author} - {message.City}");
            }

        }

        static List<string> GetRandom(List<string> list, Random random)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string temp = list[i];
                int rdm = random.Next(0, list.Count);
                list[i] = list[rdm];
                list[rdm] = temp;
            }

            return list;
        }
    }

    class Message
    {
        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }
    }
}
