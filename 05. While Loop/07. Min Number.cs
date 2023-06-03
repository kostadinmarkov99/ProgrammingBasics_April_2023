using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int currentMin = int.MaxValue;

            while (text != "Stop")
            {
                int nextNumber = int.Parse(text);

                if(nextNumber < currentMin)
                {
                    currentMin = nextNumber;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(currentMin);
        }
    }
}