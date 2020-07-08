using System;

namespace P08LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] splitedInput = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var lettersAndDigits in splitedInput)
            {
                double midleDigits = double.Parse(lettersAndDigits.Substring(1, lettersAndDigits.Length - 2));

                char firstLetter = lettersAndDigits[0];

                char lastLetter = lettersAndDigits[lettersAndDigits.Length - 1];

                int digit = 0;

                if (char.IsLower(firstLetter))
                {
                    digit = firstLetter - 96;
                    sum += midleDigits * digit;
                }
                else if (char.IsUpper(firstLetter))
                {
                    digit = firstLetter - 64;
                    sum += midleDigits / digit;
                }

                if (char.IsLower(lastLetter))
                {
                    digit = lastLetter - 96;
                    sum += digit;
                }
                else if (char.IsUpper(lastLetter))
                {
                    digit = lastLetter - 64;
                    sum -= digit;
                }
            }

            Console.WriteLine(sum.ToString("F2"));
        }
    }
}
