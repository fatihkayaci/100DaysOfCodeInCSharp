using System;

namespace day05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Question> questionBank = new List<Question>();
            foreach (var question in Data.Questions)
            {
                var questionText = question.Text;
                var questionAnswer = question.Answer;
                var newQuestion = new Question(questionText, questionAnswer);
                questionBank.Add(newQuestion);
            }
            QuizBrain quiz = new QuizBrain(questionBank);

            while (quiz.StillHasQuestions())
            {
                quiz.NextQuestion();
            }

            Console.WriteLine($"You've completed the quiz");
            Console.WriteLine($"Your final scor was: {quiz.Score}/{quiz.QuestionNumber}");
        }
    }
}