using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write($"Guess a number between {min} and {max}: ");
                    // Validate user input
                    if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }

                    guesses++;
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("The number of attempts: " + guesses);

                Console.Write("Would you like to play again (Y/N): ");
                response = Console.ReadLine().ToUpper();

                playAgain = (response == "Y");
                Console.WriteLine("Thanks for playing...");
            }

            Console.ReadKey();
        }
    }
}
