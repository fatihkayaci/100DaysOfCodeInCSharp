using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    internal class GameData
    {
        public List<Person> people = new List<Person>()
        {
            new Person(
                name: "Instagram",
                followerCount: 346,
                description: "Social media platform",
                country: "United States"
            ),
            new Person(
              name: "Cristiano Ronaldo",
              followerCount: 215,
              description: "Footballer",
              country: "Portugal"
            ),
            new Person(
              name: "Ariana Grande",
              followerCount: 183,
              description: "Musician and actress",
              country: "United States"
            ),
            new Person(
              name: "Dwayne Johnson",
              followerCount: 181,
              description: "Actor and professional wrestler",
              country: "United States"
            ),
            new Person(
              name: "Selena Gomez",
              followerCount: 174,
              description: "Musician and actress",
              country: "United States"
            ),
            new Person(
              name: "Kylie Jenner",
              followerCount: 172,
              description: "Reality TV personality and businesswoman and Self-Made Billionaire",
              country: "United States"
            ),
            new Person(
              name: "Kim Kardashian",
              followerCount: 167,
              description: "Reality TV personality and businesswoman",
              country: "United States"
            ),
            new Person(
              name: "Lionel Messi",
              followerCount: 149,
              description: "Footballer",
              country: "Argentina"
            ),
            new Person(
              name: "Beyoncé",
              followerCount: 145,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "Neymar",
              followerCount: 138,
              description: "Footballer",
              country: "Brasil"
            ),
            new Person(
              name: "National Geographic",
              followerCount: 135,
              description: "Magazine",
              country: "United States"
            ),
            new Person(
              name: "Justin Bieber",
              followerCount: 133,
              description: "Musician",
              country: "Canada"
            ),
            new Person(
              name: "Taylor Swift",
              followerCount: 131,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "Kendall Jenner",
              followerCount: 127,
              description: "Reality TV personality and Model",
              country: "United States"
            ),
            new Person(
              name: "Jennifer Lopez",
              followerCount: 119,
              description: "Musician and actress",
              country: "United States"
            ),
            new Person(
              name: "Nicki Minaj",
              followerCount: 113,
              description: "Musician",
              country: "Trinidad and Tobago"
            ),
            new Person(
              name: "Nike",
              followerCount: 109,
              description: "Sportswear multinational",
              country: "United States"
            ),
            new Person(
              name: "Khloé Kardashian",
              followerCount: 108,
              description: "Reality TV personality and businesswoman",
              country: "United States"
            ),
            new Person(
              name: "Miley Cyrus",
              followerCount: 107,
              description: "Musician and actress",
              country: "United States"
            ),
            new Person(
              name: "Katy Perry",
              followerCount: 94,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "Kourtney Kardashian",
              followerCount: 90,
              description: "Reality TV personality",
              country: "United States"
            ),
            new Person(
              name: "Kevin Hart",
              followerCount: 89,
              description: "Comedian and actor",
              country: "United States"
            ),
            new Person(
              name: "Ellen DeGeneres",
              followerCount: 87,
              description: "Comedian",
              country: "United States"
            ),
            new Person(
              name: "Real Madrid CF",
              followerCount: 86,
              description: "Football club",
              country: "Spain"
            ),
            new Person(
              name: "FC Barcelona",
              followerCount: 85,
              description: "Football club",
              country: "Spain"
            ),
            new Person(
              name: "Rihanna",
              followerCount: 81,
              description: "Musician and businesswoman",
              country: "Barbados"
            ),
            new Person(
              name: "Demi Lovato",
              followerCount: 80,
              description: "Musician and actress",
              country: "United States"
            ),
            new Person(
              name: "Victoria's Secret",
              followerCount: 69,
              description: "Lingerie brand",
              country: "United States"
            ),
            new Person(
              name: "Zendaya",
              followerCount: 68,
              description: "Actress and musician",
              country: "United States"
            ),
            new Person(
              name: "Shakira",
              followerCount: 66,
              description: "Musician",
              country: "Colombia"
            ),
            new Person(
              name: "Drake",
              followerCount: 65,
              description: "Musician",
              country: "Canada"
            ),
            new Person(
              name: "Chris Brown",
              followerCount: 64,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "LeBron James",
              followerCount: 63,
              description: "Basketball player",
              country: "United States"
            ),
            new Person(
              name: "Vin Diesel",
              followerCount: 62,
              description: "Actor",
              country: "United States"
            ),
            new Person(
              name: "Cardi B",
              followerCount: 67,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "David Beckham",
              followerCount: 82,
              description: "Footballer",
              country: "United Kingdom"
            ),
            new Person(
              name: "Billie Eilish",
              followerCount: 61,
              description: "Musician",
              country: "United States"
            ),
            new Person(
              name: "Justin Timberlake",
              followerCount: 59,
              description: "Musician and actor",
              country: "United States"
            ),
            new Person(
              name: "UEFA Champions League",
              followerCount: 58,
              description: "Club football competition",
              country: "Europe"
            ),
            new Person(
              name: "NASA",
              followerCount: 56,
              description: "Space agency",
              country: "United States"
            ),
            new Person(
              name: "Emma Watson",
              followerCount: 56,
              description: "Actress",
              country: "United Kingdom"
            ),
            new Person(
              name: "Shawn Mendes",
              followerCount: 57,
              description: "Musician",
              country: "Canada"
            ),
            new Person(
              name: "Virat Kohli",
              followerCount: 55,
              description: "Cricketer",
              country: "India"
            ),
            new Person(
              name: "Gigi Hadid",
              followerCount: 54,
              description: "Model",
              country: "United States"
            ),
            new Person(
              name: "Priyanka Chopra Jonas",
              followerCount: 53,
              description: "Actress and musician",
              country: "India"
            ),
            new Person(
              name: "9GAG",
              followerCount: 52,
              description: "Social media platform",
              country: "China"
            ),
            new Person(
              name: "Ronaldinho",
              followerCount: 51,
              description: "Footballer",
              country: "Brasil"
            ),
            new Person(
              name: "Maluma",
              followerCount: 50,
              description: "Musician",
              country: "Colombia"
            ),
            new Person(
              name: "Camila Cabello",
              followerCount: 49,
              description: "Musician",
              country: "Cuba"
            ),
            new Person(
              name: "NBA",
              followerCount: 47,
              description: "Club Basketball Competition",
              country: "United States"
            )
        };

    }
}
