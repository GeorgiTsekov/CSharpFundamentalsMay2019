using System;
using System.Collections.Generic;
using System.Linq;

namespace P03TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            List<char> numbers = new List<char>();

            List<char> lettersAndSymbols = new List<char>();

            foreach (char item in array)
            {
                if (char.IsDigit(item))
                {
                    numbers.Add(item);
                }
                else
                {
                    lettersAndSymbols.Add(item);
                }
            }

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            string decryptedString = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i] - 48);
                }
                else
                {
                    skipList.Add(numbers[i] - 48);
                }
            }
           
            for (int j = 0; j < takeList.Count; j++)
            {
                while (takeList[j] > 0)
                {
                    if (lettersAndSymbols.Count > 0)
                    {
                        decryptedString += lettersAndSymbols[0];
                        lettersAndSymbols.RemoveAt(0);
                        takeList[j]--;
                    }
                    else
                    {
                        break;
                    }
                }
                while (skipList[j] > 0)
                {
                    if (lettersAndSymbols.Count > 0)
                    {
                        lettersAndSymbols.RemoveAt(0);
                        skipList[j]--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine(decryptedString);
        }
    }
}
