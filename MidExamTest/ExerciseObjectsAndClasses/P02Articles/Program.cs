using System;

namespace P02Articles
{
    class Program
    {
        static void Main()
        {
            string[] articleArgs = Console.ReadLine()
                .Split(", ");

            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Articles articles = new Articles(title, content, author);

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(": ");

                string command = commandArgs[0];
                string value = commandArgs[1];

                if (command == "Edit")
                {
                    articles.Edit(value);
                }
                else if (command == "ChangeAuthor")
                {
                    articles.ChangeAuthor(value);
                }
                else if (command == "Rename")
                {
                    articles.Rename(value);
                }
            }

            Console.WriteLine($"{articles.Title} - {articles.Content}: {articles.Author}");
        }
    }
}
