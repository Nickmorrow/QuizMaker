using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class UIMethods
    {
        public static string StartOrLoadQuiz()
        {
            string userAnswer = "";
            string lString = "l";
            string nString = "n";

            Console.WriteLine("***Welcome to QuizMaker!***\n");
            Console.WriteLine("Press 'L' to load an existing quiz, press 'N' to start a new quiz.\n");

            do
            {
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer != lString && userAnswer != nString)
                {
                    Console.WriteLine("Please enter either 'L' or 'N.'");
                }
                
            } while (userAnswer != lString && userAnswer != nString);
            
            Console.Clear();

            return userAnswer;
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

        public static string UserAnswerCorrect()
        {
            string answer = "";
            Console.WriteLine("Is this answer correct? y/n");
            answer = Console.ReadLine();
            Console.Clear();
            return answer;
        }


    }
}
