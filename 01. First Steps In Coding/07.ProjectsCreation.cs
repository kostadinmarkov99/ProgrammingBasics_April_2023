using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int needetHours = projectCount * 3;

            string result = $"The architect {name} will need {needetHours} hours to complete {projectCount} project/s.";

            Console.WriteLine(result);
        }
    }
}