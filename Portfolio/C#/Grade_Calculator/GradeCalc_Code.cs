using System;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                int f = 0;
                Console.WriteLine("Enter number of students");
                int students = 0;
                while (f == 0)
                {
                    if (int.TryParse(Console.ReadLine(), out students))
                    {
                        f++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter number");
                    }
                }
                f = 0;
                int[] students_a = new int[students];
                int c = 0;
                double average = 0;
                double higestgrade = 0;
                string highestgradename = "";
                string lowestgradename = "";
                double lowestgrade = 100;
                string[] name = new string[students];
                double[] grade = new double[students];
                for (c = 0; c < students_a.Length; c++)
                {
                    Console.WriteLine("Enter Student #{0}'s name", c + 1);
                    name[c] = Console.ReadLine();
                    Console.WriteLine("Enter Student #{0}'s grade", c + 1);
                    while (f == 0)
                    {
                        if (double.TryParse(Console.ReadLine(), out grade[c]))
                        {
                            f++;
                        }
                        else
                        {
                            Console.WriteLine("Please enter number");
                        }
                    }
                f = 0;
                    average += grade[c];
                    if (grade[c] > higestgrade)
                    {
                        higestgrade = grade[c];
                        highestgradename = name[c];
                    }
                    if (grade[c] < lowestgrade)
                    {
                        lowestgrade = grade[c];
                        lowestgradename = name[c];
                    }
                }
                average /= students_a.Length;
                Console.WriteLine("The highest grade is {0} by {1}", higestgrade, highestgradename);
                Console.WriteLine("The lowest grade is {0} by {1}", lowestgrade, lowestgradename);
                Console.WriteLine("The average is {0}", average);
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to quit");
                Console.ReadLine();
        }
    }
}
