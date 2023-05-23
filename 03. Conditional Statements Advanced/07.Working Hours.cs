using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if(dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
            {
                if(hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else if(dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}