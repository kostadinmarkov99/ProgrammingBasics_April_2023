using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int nextNumber = int.Parse(Console.ReadLine());
            int sum = nextNumber;

            while (sum < number)
            {
                //sum new values of nextNumber
                nextNumber = int.Parse(Console.ReadLine());
                sum += nextNumber;
            }

            Console.WriteLine(sum);
        }
    }
}