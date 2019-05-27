using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Articles
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            var article = new Article
            {
                Title = input[0],
                Content = input[1],
                Author = input[2]
            };
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(": ");
                string method = line[0];
                string argument = line[1];

                switch (method)
                {
                    case "Edit":
                        {
                            article.Edit(argument);
                            break;
                        }
                    case "ChangeAuthor":
                        {
                            article.ChangeAuthor(argument);
                            break;
                        }
                    case "Rename":
                        {
                            article.Rename(argument);
                            break;
                        }
                    case "ToString":
                        {
                            article.ToString();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

            }
            article.ToString();
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Edit(string content)
        {
            Content = content;

            return Content;
        }

        public string ChangeAuthor(string author)
        {
            Author = author;
            return Author;
        }

        public string Rename(string title)
        {
            Title = title;
            return title;
        }

        public void ToString()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}

