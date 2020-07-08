using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exam26October2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> females = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int matches = 0;
            int male = -1;
            int female = 0;
            
            while (males.Count > 0 && females.Count > 0)
            {
                while (female <= 0 || male <= 0)
                {
                    if (females.Count <= 0 && males.Count <= 0)
                    {
                        return;
                    }

                    if (female <= 0 && females.Count > 0)
                    {
                        female = females.Dequeue();
                    }

                    if (male <= 0 && males.Count > 0)
                    {
                        male = males.Peek();
                        if (male <= 0 && males.Count > 0)
                        {
                            male = males.Pop();
                        }
                        else if (males.Count <= 0)
                        {
                            return;
                        }
                    }
                }
                if (female % 25 == 0 || male % 25 == 0)
                {
                    bool isTrue = false;

                    if (female % 25 == 0 && females.Count > 0)
                    {
                        females.Dequeue();
                        female = 0;
                        isTrue = true;
                    }

                    if (male % 25 == 0 && males.Count > 0)
                    {
                        males.Pop();
                        if (males.Count > 0)
                        {
                            males.Pop();
                            male = -1;
                            female = 0;
                            isTrue = true;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (isTrue)
                    {
                        continue;
                    }
                }

                if (male == female && males.Count > 0 && male > 0)
                {
                    males.Pop();
                    male = -1;
                    female = 0;
                    matches++;
                }
                else if(males.Count > 0 && male != female && male > 0)
                {
                    males.Pop();
                    male -= 2;
                    males.Push(male);
                    female = 0;
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
