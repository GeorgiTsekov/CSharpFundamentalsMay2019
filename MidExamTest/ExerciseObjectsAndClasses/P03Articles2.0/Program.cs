using System;
using System.Collections.Generic;
using System.Linq;

namespace P03Articles2._0
{
    class Program
    {
        static void Main()
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> listOfArticles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] splitedArticles = Console.ReadLine().Split(", ");

                string title = splitedArticles[0];
                string content = splitedArticles[1];
                string author = splitedArticles[2];

                Article article = new Article(title, content, author);

                listOfArticles.Add(article);
            }

            string command = Console.ReadLine();

            if (command == "title")
            {
                listOfArticles = listOfArticles
                .OrderBy(x => x.Title)
                .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }
            else if (command == "content")
            {
                listOfArticles = listOfArticles
                .OrderBy(x => x.Content)
                .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }
            else if (command == "author")
            {
                listOfArticles = listOfArticles
                .OrderBy(x => x.Author)
                .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }

        }
    }
}
