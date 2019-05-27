using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles2
{
    class Articles2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                var article = new Article
                {
                    Title = input[0],
                    Content = input[1],
                    Author = input[2]
                };
                list.Add(article);
            }

            string sortComand = Console.ReadLine();

            switch (sortComand)
            {
                case "title":
                    {
                        list = list.OrderBy(x => x.Title).ToList();
                        break;
                    }
                case "content":
                    {
                        list = list.OrderBy(x => x.Content).ToList();
                        break;
                    }
                case "author":
                    {
                        list = list.OrderBy(x => x.Author).ToList();
                        break;
                    }

                default:
                    Console.WriteLine($"Invalid sortComand");
                    break;
            }

            foreach (var article in list)
            {
                article.ToString();
            }
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public void ToString()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}

