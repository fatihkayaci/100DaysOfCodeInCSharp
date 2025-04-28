using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    internal static class Data
    {
        internal static readonly List<Question> Questions = new List<Question>
        {
            new Question("A slug's blood is green.", true),
            new Question("The loudest animal is the African Elephant.", false),
            new Question("Approximately one quarter of human bones are in the feet.", true),
            new Question("The total surface area of a human lungs is the size of a football pitch.", true),
            new Question("In West Virginia, USA, if you accidentally hit an animal with your car, you are free to take it home to eat.", true),
            new Question("In London, UK, if you happen to die in the House of Parliament, you are entitled to a state funeral.", false),
            new Question("It is illegal to pee in the Ocean in Portugal.", true),
            new Question("You can lead a cow down stairs but not up stairs.", false),
            new Question("Google was originally called 'Backrub'.", true),
            new Question("Buzz Aldrin's mother's maiden name was 'Moon'.", true),
            new Question("No piece of square dry paper can be folded in half more than 7 times.", false),
            new Question("A few ounces of chocolate can to kill a small dog.", true)
        };

        //public static IReadOnlyList<Question> Questions => _questions;
    }
}
