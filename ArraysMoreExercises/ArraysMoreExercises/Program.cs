using System;
using System.Linq;

namespace P01EncryptSortPrintArray
{
    class Program
    {
        static void Main()
        {
            int numberOfArr = int.Parse(Console.ReadLine());


            int[] namesArr = new int[numberOfArr];

            for (int i = 0; i < namesArr.Length; i++)
            {
                string name = Console.ReadLine();
                int nameInNumbers = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'A'
                        || name[j] == 'a'
                        || name[j] == 'E'
                        || name[j] == 'e'
                        || name[j] == 'I'
                        || name[j] == 'i'
                        || name[j] == 'O'
                        || name[j] == 'o'
                        || name[j] == 'U'
                        || name[j] == 'u')
                    {
                        nameInNumbers += name[j] * name.Length;
                    }
                    else
                    {
                        nameInNumbers += name[j] / name.Length;
                    }
                }

                namesArr[i] = nameInNumbers;
            }
            Array.Sort(namesArr);
            foreach (var names in namesArr)
            {
                Console.WriteLine(names);
            }
        }
    }
}
