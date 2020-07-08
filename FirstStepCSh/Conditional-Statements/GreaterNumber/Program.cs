using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if(x >= y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }


        }
    }
}
