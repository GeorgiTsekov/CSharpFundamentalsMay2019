using System;

namespace P02VowelsCount
{
    class Program
    {
        static void Main()
        {
            string document = Console.ReadLine();
            int countOfTheVowels = FindCountOfTheVowels(document);
            Console.WriteLine(countOfTheVowels);
        }

        private static int FindCountOfTheVowels(string document)
        {
            int countOfTheVowels = 0;
            document = document.ToLower();
            for (int i = 0; i < document.Length; i++)
            {
                switch (document[i])
                {
                    case 'a':
                        countOfTheVowels++;
                        break;
                    case 'e':
                        countOfTheVowels++;
                        break;
                    case 'i':
                        countOfTheVowels++;
                        break;
                    case 'o':
                        countOfTheVowels++;
                        break;
                    case 'u':
                        countOfTheVowels++;
                        break;
                    case 'y':
                        countOfTheVowels++;
                        break;
                    default:
                        break;
                }
            }
            return countOfTheVowels;
        }
    }
}
