using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                sum = sum + nextNumber;
            }

            Console.WriteLine(sum);
        }
    }
}