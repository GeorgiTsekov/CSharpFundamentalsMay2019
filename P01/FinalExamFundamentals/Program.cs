using System;

namespace P01
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] splitedInput = input.Split();

                switch (splitedInput[0])
                {
                    case "Change":
                        string newText = string.Empty;
                        if (text.Contains(splitedInput[1]))
                        {
                            newText = text.Replace(splitedInput[1], splitedInput[2]);
                        }
                        text = newText;
                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        string includeString = splitedInput[1];
                        if (text.Contains(includeString))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":
                        string endString = splitedInput[1];
                        if (!text.Contains(endString))
                        {
                            Console.WriteLine("False");
                        }
                        else
                        {
                            string trueString = string.Empty;
                            for (int i = text.Length - endString.Length; i < text.Length; i++)
                            {
                                trueString += text[i];
                            }
                            if (trueString == endString)
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }
                        }
                        break;
                    case "Uppercase":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        if (text.Contains(splitedInput[1]))
                        {
                            int index = text.IndexOf(splitedInput[1]);
                            Console.WriteLine(index);
                        }
                        break;
                    case "Cut":
                        int startIndex = int.Parse(splitedInput[1]);
                        int lenght = int.Parse(splitedInput[2]);
                        text = text.Substring(startIndex, lenght);
                        Console.WriteLine(text);
                        break;
                }
            }
        }
    }
}
