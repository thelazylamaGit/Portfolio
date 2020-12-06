using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            int f = 0;
            int largestnumber = 0;
            while (again)
            {

                Console.WriteLine("What do you want the largest number to be?");
                while (f == 0)
                {
                    if (int.TryParse(Console.ReadLine(), out largestnumber))
                    {
                        f++;
                    }
                    else
                    {
                        Console.WriteLine("Error, Please try again");
                    }
                }
                f = 0;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Random randomgenerator = new Random();
                int randomnumber = randomgenerator.Next(1, largestnumber + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----Guessing Game 2.0-----");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Guess a number from 1 to {0}", largestnumber);
                int guess = 0;
                int numberofgueses = 1;

                do
                {
                    while (f == 0)
                    {
                        if (int.TryParse(Console.ReadLine(), out guess))
                        {
                            f++;
                        }
                        else
                        {
                            Console.WriteLine("Error, Please try again");
                        }
                    }
                    f = 0;
                    if (guess > randomnumber)
                    {
                        Console.WriteLine("Too big!");
                    }
                    else if (guess < randomnumber)
                    {
                        Console.WriteLine("Too Small!");
                    }
                    else
                    {
                        Console.WriteLine("Wow you got it! The answer was {0}", randomnumber);
                        Console.WriteLine("that took you {0} guesses!", numberofgueses);
                        Console.WriteLine();
                        Console.WriteLine("Play Again? true / false");
                        again = bool.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    numberofgueses++;


                } while (guess != randomnumber);
            }
        }
    }
}
