using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    public class Person
    {
        public string? Name { get; set; }
        public int FollowerCount { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }

        public Person(string name, int followerCount, string description, string country)
        {
            Name = name;
            FollowerCount = followerCount;
            Description = description;
            Country = country;
        }
    }
}
