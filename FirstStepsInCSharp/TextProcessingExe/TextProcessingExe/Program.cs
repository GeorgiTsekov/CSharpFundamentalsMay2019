using System;

namespace P07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string explosionString = Console.ReadLine();

            int numberOfExplosions = 0;

            for (int i = 0; i < explosionString.Length; i++)
            {
                char symbol = explosionString[i];
                if (symbol == '>')
                {
                    numberOfExplosions += int.Parse(explosionString[i + 1]
                        .ToString());
                }

                if (numberOfExplosions > 0 && explosionString[i] != '>')
                {
                    i--;
                }
                if (i + 1 >= explosionString.Length 
                    && numberOfExplosions > 0 && explosionString[i + 1] != '>')
                {
                    explosionString = explosionString.Remove(i + 1, i + 1);
                }
                else if (i + 1 < explosionString.Length 
                    && explosionString[i + 1] != '>' 
                    && numberOfExplosions > 0)
                {
                    explosionString = explosionString.Remove(i + 1, 1);
                    numberOfExplosions--;
                }              
            }

            Console.WriteLine(explosionString);
        }
    }
}
