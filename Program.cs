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
            Console.WriteLine("Гра почалась!");
            Console.WriteLine("Генеруємо число ...");
            int attempts = 0; // спроби     
            bool guessed = false; //вгадав 

            while (!guessed)
            {
                Console.WriteLine("Введіть ваше припущення (1-100): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int guess))
                {
                    attempts++;
                    if (guess == secretNumber)
                    {
                        guessed = true;
                        Console.WriteLine("Вітаю! Ви вгадали число {0} за {1} спроб.", secretNumber, attempts);
                    }
                    else if (guess < secretNumber)
                    {
                        guessed = false;
                        Console.WriteLine("Загадане число більше");
                    }
                    else 
                    {
                        guessed = false;
                        Console.WriteLine("Загадане число менше.");
                    }
                }
                else
                    {
                        Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число від 1 до 100.");
                    }
                

            }
            Console.WriteLine("Гра завершена!");
            Console.ReadLine();
        }
    }
}
