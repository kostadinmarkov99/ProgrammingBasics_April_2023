using System;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int temp = 1;

            while (true)
            {
                if(n < temp)
                {
                    break;
                }

                Console.WriteLine(temp);

                temp = temp * 2 + 1;
            }
        }
    }
}