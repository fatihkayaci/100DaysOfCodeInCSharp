using day01;

namespace day01
{
    public class Task
    {
        static readonly Art logo = new Art();
        static readonly Random rand = new Random();
        static List<int> playerCards = new List<int>(), computerCards = new List<int>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Do you want to play a game of Blackjack? Type 'y' or 'n': ");
                char start = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (start == 'y')
                {
                    Console.Clear();
                    playGame();
                }
                else
                {
                    Console.WriteLine("Goodbye! 👋");
                    break;
                }
            }
        }

        static int DealCard()
        {
            List<int> cards = new List<int>() { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            int randomCard = rand.Next(cards.Count);
            return cards[randomCard];
        }

        static int CalculateScore(List<int> cards)
        {
            int score = cards.Sum();
            if (cards.Contains(11) && score > 21)
            {
                cards[cards.IndexOf(11)] = 1;
                score = cards.Sum();
            }
            return score;
        }

        static string compare(int playerScore, int computerScore)
        {
            if (playerScore > 21)
                return "You went over. You lose 😭";
            else if (computerScore > 21)
                return "Opponent went over. You win 😁";
            else if (playerScore == computerScore)
                return "Draw 🙃";
            else if (playerScore == 21 && playerCards.Count == 2)
                return "Blackjack! You win 😎";
            else if (computerScore == 21 && computerCards.Count == 2)
                return "Computer has Blackjack! You lose 😱";
            else if (playerScore > computerScore)
                return "You win 😊";
            else
                return "You lose 😤";
        }

        static void playGame()
        {
            // Reset hands for new game
            playerCards.Clear();
            computerCards.Clear();

            bool gameOver = false;
            int playerScore = 0, computerScore = 0;

            Console.WriteLine(logo.ToString());

            // Deal initial cards
            for (int i = 0; i < 2; i++)
            {
                playerCards.Add(DealCard());
                computerCards.Add(DealCard());
            }

            // Player's turn
            while (!gameOver)
            {
                playerScore = CalculateScore(playerCards);
                computerScore = CalculateScore(computerCards);

                Console.WriteLine($"    Your cards: {string.Join(", ", playerCards)}, current score: {playerScore}");
                Console.WriteLine($"    Computer's first card: {computerCards[0]}");

                if (playerScore == 21 || computerScore == 21 || playerScore > 21)
                    gameOver = true;
                else
                {
                    Console.Write("Type 'y' to get another card, type 'n' to pass: ");
                    char shouldContinue = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (shouldContinue == 'y')
                        playerCards.Add(DealCard());
                    else
                        gameOver = true;
                }
            }

            // Computer's turn
            while (CalculateScore(computerCards) < 17)
                computerCards.Add(DealCard());

            // Final scores
            playerScore = CalculateScore(playerCards);
            computerScore = CalculateScore(computerCards);

            Console.WriteLine($"    Your final hand: {string.Join(", ", playerCards)}, final score: {playerScore}");
            Console.WriteLine($"    Computer's final hand: {string.Join(", ", computerCards)}, final score: {computerScore}");
            Console.WriteLine(compare(playerScore, computerScore));
        }
    }
}