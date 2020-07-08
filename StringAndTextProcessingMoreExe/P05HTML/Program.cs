using System;

namespace P05HTML
{
    class Program
    {
        static void Main()
        {
            string title = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");

            string content = Console.ReadLine();

            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            string input;

            while ((input = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {input}");
                Console.WriteLine("</div>");
            }
        }
    }
}
