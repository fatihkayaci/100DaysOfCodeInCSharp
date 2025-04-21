using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    internal class GameDb
    {
        public static Dictionary<string, MenuItem> Menu = new Dictionary<string, MenuItem>
        {
            {
                "espresso", 
                new MenuItem
                {
                    Ingredients = new Ingredients{Water= 50, Coffe= 18},
                    Cost = 1.5
                }
            },
            {
                "latte",
                new MenuItem
                {
                    Ingredients = new Ingredients{Water= 200, Milk = 150, Coffe = 24},
                    Cost = 2.5
                }
            },
            {
                "cappuccino",
                new MenuItem
                {
                    Ingredients = new Ingredients{Water = 250, Milk = 100, Coffe = 24},
                    Cost = 3.0
                }
            }
        };
        public static Dictionary<string, int> Resources = new Dictionary<string, int>
        {
            { "water", 300 },
            { "milk", 200 },
            { "coffee", 100 }
        };
    }
}
