using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Welcome to the Guess My Number game!");

            Random random = new Random();
            int magicNumber = random.Next(1, 101); // Random number between 1 and 100

            int guess = -1;
            int attempts = 0;

            Console.WriteLine("I've picked a number between 1 and 100. Can you guess it?");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                    Console.WriteLine($"It took you {attempts} attempts to guess the correct number.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing! Goodbye.");
            }
        }
    }
}