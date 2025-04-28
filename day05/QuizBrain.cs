using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    internal class QuizBrain
    {
        public int QuestionNumber { get; private set; }
        public List<Question> QuestionList{ get; }
        public int Score { get; private set; }
        public QuizBrain(List<Question> qList)
        {
            QuestionNumber = 0;
            QuestionList = qList ?? new List<Question>();
            Score = 0;
        }

        public bool StillHasQuestions()
        {
            return QuestionNumber < QuestionList.Count;
        }

        public void NextQuestion()
        {
            Question currentQuestion = QuestionList[QuestionNumber];
            QuestionNumber++;
            Console.WriteLine($"{QuestionNumber}: {currentQuestion.Text} (True/False):");
            bool user_answer = Convert.ToBoolean(Console.ReadLine()?.ToLower());
            CheckAnswer(user_answer, currentQuestion.Answer);
        }
        public void CheckAnswer(bool answer, bool correctAnswer)
        {
            if (answer == correctAnswer)
            {
                Console.WriteLine("You got it right!");
                Score++;
            }
            else
            {
                Console.WriteLine("That's wrong.");
            }
            Console.WriteLine($"The correct answer was: {correctAnswer}");
            Console.WriteLine($"Your current score is: {Score}/{QuestionNumber}");
            Console.WriteLine("\n");
        }
    }
}
