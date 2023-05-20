using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double fullPrice = meters * 7.61;
            double discount = fullPrice * 0.18;
            double finalPrice = fullPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}