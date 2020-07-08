using System;

namespace ArreyMoreExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nameInLetters = -1;

            int[] maxArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char[] array = name.ToCharArray();
                int sum = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    nameInLetters = array[j];

                    if (nameInLetters == 65 || nameInLetters == 97 || nameInLetters == 69 || nameInLetters == 101 || nameInLetters == 73 || nameInLetters == 105 || nameInLetters == 79 || nameInLetters == 111 || nameInLetters == 85 || nameInLetters == 117)
                    {
                        sum += (nameInLetters * array.Length);
                    }
                    else
                    {
                        sum += (nameInLetters / array.Length);
                    }
                }
                maxArray[i] = sum;
            }
            Array.Sort(maxArray);
            foreach (var item in maxArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
