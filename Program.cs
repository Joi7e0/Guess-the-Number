using System;
using System.Text;

namespace projekt
{

    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // UtF-8

            Console.ForegroundColor = ConsoleColor.Green;
            Random random = new Random();
            int secretNumber = random.Next(0, 100);
            Console.WriteLine("The game has started!");
            Console.WriteLine("Generating a number ...");
            int attempts = 0; // sprob     
            bool guessed = false; // + 

            while (!guessed)
            {
                Console.WriteLine("Enter your guess (1-100): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int guess))
                {
                    attempts++;
                    if (guess == secretNumber)
                    {
                        guessed = true;
                        Console.WriteLine("Congratulations! You guessed the number {0} in {1} attempts.", secretNumber, attempts);
                    }
                    else if (guess < secretNumber)
                    {
                        guessed = false;
                        Console.WriteLine("The guessed number is higher.");
                    }
                    else 
                    {
                        guessed = false;
                        Console.WriteLine("The guessed number is lower.");
                    }
                }
                else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
                    }
                

            }
            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
    }
}
