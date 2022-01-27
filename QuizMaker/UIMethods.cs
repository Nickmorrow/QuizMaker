using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class UIMethods
    {
        public static bool NewQuiz()
        {
            string userAnswer = "";
            bool start;

            Console.WriteLine("***Welcome to QuizMaker!***\n");
            Console.WriteLine("Press 'L' to load an existing quiz, press 'N' to start a new quiz.\n");

            do
            {
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer != "n" && userAnswer != "l")
                {
                    Console.WriteLine("Please enter either 'L' or 'N.'");
                }

            } while (userAnswer != "n" && userAnswer != "l");

            Console.Clear();
            start = userAnswer == "n";
            return start;
        }

        public static string UserQuestion()
        {
            string question = "";
            Console.WriteLine("Enter a multiple choice question");
            question = Console.ReadLine();
            Console.Clear();
            return question;
        }

        public static string UserAnswer()
        {
            string answer = "";
            Console.WriteLine("Enter an answer");
            answer = Console.ReadLine();
            Console.Clear();
            return answer;
        }

        public static bool UserAnswerCorrect()
        {
            bool isCorrect;
            string answer = "";
            Console.WriteLine("Is this answer correct? y/n");
            answer = Console.ReadLine();
            Console.Clear();
            isCorrect = answer.ToLower() == "y";
            return isCorrect;
        }

        public static QuestionAndAnswer GetQuestion()
        {
            throw new NotImplementedException();
            //todo: implement :)

            Console.WriteLine("Enter a multiple choice question");
            QuestionAndAnswer.question = Console.ReadLine();
            Console.Clear();
            return QuestionAndAnswer.question;
        }

        public static Answer GetAnswer()
        {
            throw new NotImplementedException();
            //todo: implement :)
        }


    }
}
