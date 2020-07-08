using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int aCake = int.Parse(Console.ReadLine());
            int bCake = int.Parse(Console.ReadLine());
            int cakesPieces = bCake * aCake;
            int piesesLeft = 0;
            int cakePiecesEaten = 0;


            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int currentPieces = int.Parse(command);
                cakePiecesEaten += currentPieces;
                piesesLeft = Math.Abs(cakePiecesEaten - cakesPieces);
                if (cakePiecesEaten > cakesPieces)
                {                    
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{piesesLeft} pieces are left.");
            }
            else
            {
                int difference = cakePiecesEaten - cakesPieces;
                Console.WriteLine($"No more cake left! You need {difference} pieces more.");
            }
        }
    }
}
