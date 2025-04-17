using System;

namespace day03
{
    public class Program
    {
        private static readonly Art art = new Art();
        private static readonly GameData data = new GameData();
        private static readonly Random rand = new Random();
        private static int score = 0;

        public static void Main(string[] args)
        {
            art.DisplayLogo();
            PlayGame();
        }

        private static void PlayGame()
        {
            var currentPerson = GetRandomPerson();
            while (true)
            {
                Console.Clear();
                DisplayGameInfo(currentPerson);

                var nextPerson = GetRandomPerson();
                DisplayVs();
                DisplayPersonInfo(nextPerson, "B");

                var choice = GetUserChoice();
                if (!IsChoiceCorrect(choice, currentPerson, nextPerson))
                {
                    GameOver();
                    return;
                }

                score++;
                currentPerson = nextPerson;
            }
        }

        private static Person GetRandomPerson()
        {
            return data.people[rand.Next(0, data.people.Count)];
        }

        private static void DisplayGameInfo(Person person)
        {
            art.DisplayLogo();
            Console.WriteLine($"Score: {score}");
            DisplayPersonInfo(person, "A");
        }

        private static void DisplayPersonInfo(Person person, string label)
        {
            Console.WriteLine($"Compare {label}: {person.Name}, a {person.Description}, from {person.Country}");
            Console.WriteLine($"Followers: {person.FollowerCount} million"); // Opsiyonel
        }
        private static void DisplayVs()
        {
            art.DisplayVs();
        }

        private static char GetUserChoice()
        {
            while (true)
            {
                Console.Write("Who has more followers? Type 'a' or 'b': ");
                var input = char.ToLower(Console.ReadKey().KeyChar);
                if (input == 'a' || input == 'b')
                    return input;

                Console.WriteLine("\nInvalid input! Please try again.");
            }
        }

        private static bool IsChoiceCorrect(char choice, Person current, Person next)
        {
            bool isACorrect = choice == 'a' && current.FollowerCount > next.FollowerCount;
            bool isBCorrect = choice == 'b' && next.FollowerCount > current.FollowerCount;
            return isACorrect || isBCorrect;
        }

        private static void GameOver()
        {
            Console.WriteLine($"\nSorry, that's wrong. Final score: {score}");
            Console.Write("Play again? (y/n): ");
            if (char.ToLower(Console.ReadKey().KeyChar) == 'y')
            {
                score = 0;
                PlayGame();
            }
        }
    }
}