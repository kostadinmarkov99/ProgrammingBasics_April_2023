using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double newBalance = double.Parse(input);

                if(newBalance <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {newBalance:f2}");

                sum += newBalance;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}