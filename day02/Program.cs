using System;

namespace day02
{
    public class Task
    {
        public static void Main(string[] args)
        {
            Art logo = new Art();
            Random rand = new Random();
            Console.WriteLine(logo.ToString());
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Choose a difficulty. Type 'easy' or 'hard': ");
            string? choiceDifficulty = Console.ReadLine()?.ToLower();
            int randomNumber = rand.Next(1, 100);
            if (choiceDifficulty == "easy")
                EasyGame(randomNumber);
            else if (choiceDifficulty == "hard")
                HardGame(randomNumber);
        }
        static void Game(int randomNumber, int attempts)
        {
            bool continueGame = true;
            while (continueGame)
            {
                Console.WriteLine($"You have {attempts} attempts remaining to guess the number.");
                int guess = Convert.ToInt16(Console.ReadLine());
                if (guess > randomNumber)
                    Console.WriteLine("Too high.");
                else if (guess < randomNumber)
                    Console.WriteLine("Too low.");
                else if (guess == randomNumber)
                {
                    Console.WriteLine($"You got it! The answer was {randomNumber}");
                    continueGame = false;
                }
                attempts--;
                if (attempts == 0)
                {
                    continueGame = false;
                    Console.WriteLine($"You've run out of guesses. Refresh the page to run again. number: {randomNumber}");
                }
            }
        }
        static void EasyGame(int randomNumber)
        {
            int attemtps = 10;
            Game(randomNumber, attemtps);
        }
        static void HardGame(int randomNumber)
        {
            int attemtps = 5;
            Game(randomNumber, attemtps);
        }
    }
}