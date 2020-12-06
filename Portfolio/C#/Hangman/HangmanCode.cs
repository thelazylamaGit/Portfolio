using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {

                Random randomgenerator = new Random();
                int randomnumber = randomgenerator.Next(0, 19);
                string[] word = new string[19];
                word[0] = "Watermelon";
                word[1] = "Helicopter";
                word[2] = "Peanut";
                word[3] = "Controller";
                word[4] = "Computer";
                word[5] = "Pumpkin";
                word[6] = "Elephant";
                word[7] = "Cucumber";
                word[8] = "Sword";
                word[9] = "Curtain";
                word[10] = "Mountain";
                word[11] = "Table";
                word[12] = "Meerkat";
                word[13] = "Electric";
                word[14] = "Thunder";
                word[15] = "Country";
                word[16] = "Compass";
                word[17] = "Guitar";
                word[18] = "Treadmill";
                string theword = word[randomnumber];
                string hiddenword = new string('*', theword.Length);
                int c = 0;
                int i = 0;
                int f = 0;
                char letter;
                List<char> wrongLetters = new List<char>();
                do
                {
                    Console.WriteLine(char.ToUpper(hiddenword[0]) + hiddenword.Substring(1));
                    Console.WriteLine("Select Letter");
                    Console.Write("Wrong Letters: ");
                    for (int e = 0; e < wrongLetters.Count; e++)
                    {
                        Console.Write("{0} ", wrongLetters[e]);
                    }
                    Console.WriteLine();
                    if (char.TryParse(Console.ReadLine(), out letter))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Guess must be one letter");
                    }
                    if (theword.Contains(letter, StringComparison.OrdinalIgnoreCase))
                    {
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} is in the word", letter);
                            Console.ResetColor();
                            int pos = theword.IndexOf(letter);
                            if (pos == -1)
                            {
                                pos++;
                            }
                            hiddenword = hiddenword.Remove(pos, 1);
                            hiddenword = hiddenword.Insert(pos, letter.ToString());
                            theword = theword.Remove(pos, 1);
                            theword = theword.Insert(pos, " ");
                            c++;
                        } while (theword.Contains(letter, StringComparison.OrdinalIgnoreCase));
                    }
                    else
                    {
                        if (!wrongLetters.Contains(letter))
                        {
                            wrongLetters.Add(letter);
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} is not in the word", letter);
                        Console.ResetColor();
                    }
                    i++;
                } while (c < theword.Length);
                Console.Clear();
                Console.Write("{0} was the word!", char.ToUpper(hiddenword[0]) + hiddenword.Substring(1));
                Console.WriteLine();
                Console.WriteLine("Play again? yes/no");
                do
                {
                    string yes = Console.ReadLine();
                    if (yes == "yes")
                    {
                        again = true;
                        f++;
                    }
                    else if (yes == "no")
                    {
                        again = false;
                        f++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                } while (f < 0);
                Console.Clear();
            } while (again == true);



        }
    }
}
