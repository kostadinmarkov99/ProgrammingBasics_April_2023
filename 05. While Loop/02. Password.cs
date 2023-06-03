using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                inputPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");

        }
    }
}