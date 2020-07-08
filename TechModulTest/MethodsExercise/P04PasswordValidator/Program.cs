using System;

namespace P04PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            bool isBetweenSixAndTenChars = CheckCountOfCharacters(password);
            bool isOnlyLettersAndDigits = CheckCharsForLetterAndDigits(password);
            bool haveAtLeastTwoDigits = CheckForMinTwoDigits(password);

            if (!isBetweenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isOnlyLettersAndDigits && isBetweenSixAndTenChars && haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool CheckCountOfCharacters(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CheckCharsForLetterAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                    break;
                }
            }
            return true;
            
        }

        private static bool CheckForMinTwoDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
