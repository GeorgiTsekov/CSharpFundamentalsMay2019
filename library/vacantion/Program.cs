    using System;

    namespace vacantion
    {
        class Program
        {
            static void Main(string[] args)
            {
                double allMoneyForVacantion = double.Parse(Console.ReadLine());
                double allMoney = double.Parse(Console.ReadLine());
                int dayscounter = 0;
                int spendCounter = 0;

                while (allMoney < allMoneyForVacantion)
                {
                    dayscounter++;
                    string command = Console.ReadLine();
                    double allMoneyForS = double.Parse(Console.ReadLine());

                    if (command == "spend")
                    {
                        spendCounter++;
                        allMoney -= allMoneyForS;
                        if (allMoney < 0)
                        {
                            allMoney = 0;
                        }
                        else if (spendCounter >= 5)
                        {
                            Console.WriteLine("You can't save the money.");
                            Console.WriteLine(dayscounter);
                            break;
                        }
                    }
                    else if (command == "save")
                    {
                        allMoney += allMoneyForS;
                        spendCounter = 0;
                        if (allMoney >= allMoneyForVacantion)
                        {
                            Console.WriteLine($"You saved the money for {dayscounter} days.");
                        }
                    }
                }
            }
        }
    }
