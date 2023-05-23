using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) 

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if(fruit == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.5);
                }
                else if(fruit == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.2);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.85);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.45);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.7);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.5);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.7);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.25);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.9);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.6);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 3.0);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.6);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 4.2);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}