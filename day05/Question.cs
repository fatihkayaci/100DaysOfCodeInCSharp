using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    internal class Question
    {
        public string? Text {  get; set; }
        public bool Answer { get; set; }

        public Question(string? Text, bool Answer)
        {
            this.Text = Text;
            this.Answer = Answer;
        }
    }
}
