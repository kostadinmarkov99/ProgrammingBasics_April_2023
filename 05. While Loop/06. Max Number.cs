using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int currentMax = int.MinValue;

            while (text != "Stop")
            {
                int nextNumber = int.Parse(text); 

                if(nextNumber > currentMax)
                {
                    currentMax = nextNumber;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(currentMax);
        }
    }
}