using System;

namespace P01ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(", ");

            for (int i = 0; i < array.Length; i++)
            {
                bool isValid = false;

                string word = array[i];

                if (word.Length > 3 && word.Length < 16)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if ((char.IsLetterOrDigit(word[j])
                            || word[j] == '_'
                            || word[j] == '-')
                            && word.Length >= 3
                            && word.Length <= 16)
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                
                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
