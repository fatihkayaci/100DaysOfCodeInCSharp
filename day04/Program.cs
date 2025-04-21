using System;

namespace day04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueProgress = true;
            while (continueProgress)
            {
                Console.Write("What would you like? (espresso/latte/cappuccino):");
                string? userChoice = Console.ReadLine().ToLower();

                if (userChoice == "off")
                    continueProgress = false;
                else
                    CoffeeMachine(userChoice);
            }
        }
        private static void Report()
        {
            
            foreach(var resource in GameDb.Resources)
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
            
            Console.WriteLine("Do you want detailed information about making coffee? 'yes' or 'no'");
            string? lowerCase = null;
            string? coffeDetail = Console.ReadLine();
            if (coffeDetail != null)
            {
                lowerCase = coffeDetail.ToLower();
            }

            if (lowerCase == "yes")
            {
                foreach (var item in GameDb.Menu)
                {
                    Console.WriteLine($"İçecek: {item.Key}");
                    Console.WriteLine($"  - Water: {item.Value.Ingredients.Water}ml");
                    Console.WriteLine($"  - Milk: {item.Value.Ingredients.Milk}ml");
                    Console.WriteLine($"  - Coffe: {item.Value.Ingredients.Coffe}gr");
                    Console.WriteLine($"  - Cost: ${item.Value.Cost}\n");
                }
            }
        }
        private static void CheckResourcesSufficient(string userChoice)
        {
            var menuItem = GameDb.Menu[userChoice];
            var ingredients = menuItem.Ingredients;

            if (ingredients.Water > GameDb.Resources["water"])
            {
                Console.WriteLine("Sorry there is not enough water");
                return;
            }
            if (ingredients.Milk > GameDb.Resources["milk"])
            {
                Console.WriteLine("Sorry there is not enough milk");
                return;
            }
            if (ingredients.Coffe > GameDb.Resources["coffee"])
            {
                Console.WriteLine("Sorry there is not enough coffe");
                return;
            }
            Console.WriteLine();
            ProcessCoin(userChoice);

        }
        private static void ProcessCoin(string userChoice)
        {
            Console.WriteLine("Please insert coins.");
            Console.Write("How many quarters: ");
            float quarters = float.Parse(Console.ReadLine());

            Console.Write("How many dimes: ");
            float dimes = float.Parse(Console.ReadLine());

            Console.Write("How many nickles: ");
            float nickles = float.Parse(Console.ReadLine());

            Console.Write("How many pennies: ");
            float pennies = float.Parse(Console.ReadLine());

            float result = (quarters * 0.25f) + (dimes * 0.10f) + (nickles * 0.05f) + (pennies * 0.01f);

            var menuItem = GameDb.Menu[userChoice];
            var cost = menuItem.Cost;

            if (result < cost)
                Console.WriteLine("Sorry that's not enough money. Money refunded.");
            else
            {
                Console.WriteLine($"Here is {(result - cost):F2} in change.");
                Console.WriteLine($"Here is your {userChoice} Enjoy.");
                UpdateResources(userChoice);    
            }
        }
        private static void UpdateResources(string userChoice)
        {
            var key = GameDb.Menu[userChoice];
            var value = key.Ingredients;

            var resource = GameDb.Resources;

            resource["water"] -= value.Water;
            resource["coffee"] -= value.Coffe;
            resource["milk"] -= value.Milk;
        }

        private static void CoffeeMachine(string userChoice)
        {
            if (userChoice == "report")
                Report();
            else if (userChoice == "espresso" || userChoice == "latte" || userChoice == "cappuccino")
                CheckResourcesSufficient(userChoice);
        }
    }
}