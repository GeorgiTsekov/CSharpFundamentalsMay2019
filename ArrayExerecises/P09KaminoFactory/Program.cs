using System;
using System.Linq;

namespace P09KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int arraysLenght = int.Parse(Console.ReadLine());

            int topSequennceIndex = 0;

            int ultimateSequenceIndex = 0;

            int maxCounter = 0;
            int ultimateCounter = 0;

            int[] sequenceIndex = new int[arraysLenght]; 

            int[] sequenceBestIndex = new int[arraysLenght];

            while (true)
            {
                string sequence = Console.ReadLine();

                int counter = 1;


                if (sequence == "Clone them!")
                {
                    break;
                }
                else
                {
                    sequenceIndex = sequence.Split(new[] { "!" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                    ultimateSequenceIndex++;
                    maxCounter = 0;
                    for (int i = 1; i < sequenceIndex.Length; i++)
                    {
                        if (sequenceIndex[i - 1] == 1)
                        {
                            if (sequenceIndex[i - 1] == sequenceIndex[i])
                            {
                                counter++;
                            }
                        }
                        else
                        {
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                            }
                            counter = 1;
                        }
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    if (ultimateCounter < maxCounter)
                    {
                        ultimateCounter = maxCounter;
                        sequenceBestIndex = sequenceIndex;
                        topSequennceIndex = ultimateSequenceIndex;
                    }
                    else if (ultimateCounter == maxCounter)
                    {
                        for (int i = 0; i < sequenceBestIndex.Length; i++)
                        {
                            if (sequenceBestIndex[i] < sequenceIndex[i])
                            {
                                sequenceBestIndex = sequenceIndex;
                                topSequennceIndex = ultimateSequenceIndex;
                            }
                            else if (sequenceBestIndex[i] == sequenceIndex[i])
                            {
                                if (sequenceBestIndex.Sum() < sequenceIndex.Sum())
                                {
                                    sequenceIndex = sequenceBestIndex;
                                    ultimateCounter = sequenceIndex.Sum();
                                    topSequennceIndex = ultimateSequenceIndex;
                                }
                                else
                                {
                                    ultimateCounter = sequenceBestIndex.Sum();
                                }
                            }
                        }
                    }
                }                
            }
            Console.WriteLine($"Best DNA sample {topSequennceIndex} with sum: {ultimateCounter}.");
            Console.WriteLine(string.Join(" ", sequenceBestIndex));
        }
    }
}
