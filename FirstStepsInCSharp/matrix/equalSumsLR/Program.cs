using System;

namespace equalSumsLR
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();

                int currentDigitFirst = int.Parse(currentNum[0].ToString());
                int currentDigitSecond = int.Parse(currentNum[1].ToString());
                int currentDigitThird = int.Parse(currentNum[2].ToString());
                int currentDigitFourth = int.Parse(currentNum[3].ToString());
                int currentDigitFifth = int.Parse(currentNum[4].ToString());
                int leftSum = currentDigitFirst + currentDigitSecond;
                int rightSum = currentDigitFourth + currentDigitFifth;
                int middleSum = Math.Abs(leftSum - rightSum) - currentDigitThird;

                if ((leftSum == rightSum) || (middleSum == 0))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
