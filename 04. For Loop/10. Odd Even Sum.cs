using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    evenSum = evenSum + newNumber;
                }
                else
                {
                    oddSum = oddSum + newNumber;
                }
            }

            if(oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}