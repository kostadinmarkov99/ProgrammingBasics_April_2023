using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double charity = double.Parse(Console.ReadLine());
            double allMoney = 0;
            double cashPaind = 0;
            double cardPaid = 0;
            int cashCount = 0;
            int cardCount = 0;

            string input = Console.ReadLine();

            int counter = 1;

            while (input != "End")
            {
                double productPrice = double.Parse(input);

                if (counter % 2 == 1)
                {
                    // cash
                    if (productPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        input = Console.ReadLine();
                        counter++;
                        continue;
                    }
                    else
                    {
                        cashPaind += productPrice;
                        cashCount++;
                    }
                }
                else
                {
                    // card
                    if (productPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        input = Console.ReadLine();
                        counter++;
                        continue;
                    }
                    else
                    {
                        cardPaid += productPrice;
                        cardCount++;
                    }
                }

                allMoney += productPrice;
                Console.WriteLine("Product sold!");
                counter++;

                if(allMoney >= charity)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if(allMoney >= charity)
            {
                double cs = cashPaind / cardCount;
                double cc = cardPaid / cardCount;
                Console.WriteLine($"Average CS: {cs:f2}");
                Console.WriteLine($"Average CC: {cc:f2}");

            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}