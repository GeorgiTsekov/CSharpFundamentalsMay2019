using System;

namespace P04PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            bool isLength = IsLengthValid(password);
            bool areLetterOrDigit = AreLetterOrDigitValid(password);
            bool containsTwoDigits = ContainsTwoDigitsValid(password);
            
            PrintResult(isLength, areLetterOrDigit, containsTwoDigits);
        }

        private static void PrintResult(bool isLength, bool areLetterOrDigit, bool containsTwoDigits)
        {
            if (!isLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!areLetterOrDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!containsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLength && areLetterOrDigit && containsTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsTwoDigitsValid(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }         
        }

        private static bool AreLetterOrDigitValid(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsLengthValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
