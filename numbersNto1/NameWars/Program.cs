using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxSum = int.MinValue;
            string winner = String.Empty;

            while (name != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int iValue = (int)name[i];
                    sum += iValue;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    winner = name;
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {maxSum}!");
        }
    }
}
