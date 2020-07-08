using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areasquare = a * a;
                Console.WriteLine($"{areasquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double arearectangle = a * b;
                Console.WriteLine($"{arearectangle:f3}");
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double areacircle = a * a * Math.PI;
                Console.WriteLine($"{areacircle:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areatriangle = a * h / 2;
                Console.WriteLine($"{areatriangle:f3}");
            }
        }
    }
}

