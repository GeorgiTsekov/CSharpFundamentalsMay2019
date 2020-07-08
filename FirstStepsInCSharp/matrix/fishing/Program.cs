using System;

namespace fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
           

            for (int numberOne = 1; numberOne <= n; numberOne++)
            {
                for (int numberTwo = 1; numberTwo <= n; numberTwo++)
                {
                    for (char numberThree = 'a'; numberThree < 'a' + l; numberThree++)
                    {
                        for (char numberFour = 'a'; numberFour < 'a' + l; numberFour++)
                        {
                            for (int numberFive = 1; numberFive <= n; numberFive++)
                            {
                                if (numberFive > numberOne && numberFive > numberTwo)
                                {
                                    Console.Write($"{numberOne}{numberTwo}{(char)numberThree}{(char)numberFour}{numberFive} ");

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
