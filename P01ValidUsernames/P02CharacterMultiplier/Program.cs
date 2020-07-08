using System;

namespace P02CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string word1 = words[0];

            string word2 = words[1];

            int sum = 0;

            if (word1.Length >= word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if (i < word2.Length)
                    {
                        sum += word1[i] * word2[i];
                    }
                    else
                    {
                        sum += word1[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    if (i < word1.Length)
                    {
                        sum += word1[i] * word2[i];
                    }
                    else
                    {
                        sum += word2[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
