using System;

namespace HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            PrintH1(title);
            string article = Console.ReadLine();
            PrintArticle(article);
            string comand = Console.ReadLine();

            while (comand != "end of comments")
            {
                PrintComment(comand);
                comand = Console.ReadLine();
            }
        }

        private static void PrintComment(string comand)
        {
            Console.WriteLine(@"<div>");
            Console.WriteLine('\t' + comand);
            Console.WriteLine(@"</div>");
        }

        private static void PrintArticle(string article)
        {
            Console.WriteLine(@"<article>");
            Console.WriteLine('\t' + article);
            Console.WriteLine(@"</article>");
        }

        private static void PrintH1(string title)
        {
            Console.WriteLine(@"<h1>");
            Console.WriteLine('\t' + title);
            Console.WriteLine(@"</h1>");
        }
    }
}
