using System;

namespace FirstStepsInCodding_22_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
          
            //string fullName = firstName + " " + lastName + " You are " + age + " years old!";

            string interpolationName = $"Hello, {firstName}!";

            Console.WriteLine(interpolationName);
        }
    }
}