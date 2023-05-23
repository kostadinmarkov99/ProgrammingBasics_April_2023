using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            if(dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                Console.WriteLine(12);
            }
            else if(dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if(dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}