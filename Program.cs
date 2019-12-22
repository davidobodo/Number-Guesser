using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Obodo David";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);

            int correctNumber = 7;

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();

                if(!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Sorry, please enter an actual number");

                    Console.ResetColor();

                    continue;
                }

                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number, please try again");

                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You are correct!!!");

            Console.ResetColor();
        }
    }
}
