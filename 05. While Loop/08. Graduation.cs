using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int poorNotesCount = 0;
            int grade = 1;

            while (grade <= 12)
            {
                double currentNote = double.Parse(Console.ReadLine());

                if(currentNote < 4)
                {
                    poorNotesCount = poorNotesCount + 1;

                    if(poorNotesCount > 1)
                    {
                        break;
                    }

                    continue;
                }

                sum = sum + currentNote;
                grade++;

            }

            if (poorNotesCount > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double average = sum / 12.0;

                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}