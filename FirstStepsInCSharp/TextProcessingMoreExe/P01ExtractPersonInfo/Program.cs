using System;

namespace P01ExtractPersonInfo
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                int firstNameIndex = input.IndexOf('@');
                int lastNameIndex = input.IndexOf('|');
                int firstAgeIndex = input.IndexOf('#');
                int lastAgeIndex = input.IndexOf('*');

                string name = input.Substring(firstNameIndex + 1, lastNameIndex - firstNameIndex - 1);
                string age = input.Substring(firstAgeIndex + 1, lastAgeIndex - firstAgeIndex - 1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
