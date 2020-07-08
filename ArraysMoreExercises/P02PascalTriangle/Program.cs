using System;

namespace P02PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] oldPaskal = new int[1];
            oldPaskal[0] = 1;
            Console.WriteLine(oldPaskal[0]);
            for (int i = 1; i < size; i++)
            {
                int[] nextPaskal = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    int secondNum = 0;
                    if ((j - 1) >= 0) secondNum = oldPaskal[j - 1];
                    if (j < i) nextPaskal[j] = oldPaskal[j] + secondNum;
                    else nextPaskal[j] = secondNum;
                }
                Console.WriteLine(string.Join(" ", nextPaskal));
                oldPaskal = nextPaskal;
            }
        }
    }
}