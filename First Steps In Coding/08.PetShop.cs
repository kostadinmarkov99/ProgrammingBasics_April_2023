using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogPackets = int.Parse(Console.ReadLine());
            int catPackets = int.Parse(Console.ReadLine());

            double dogPacketPrice = dogPackets * 2.5;
            int catPacketPrice = catPackets * 4;

            double result = dogPacketPrice + catPacketPrice;

            Console.WriteLine(result + " lv.");
        }
    }
}