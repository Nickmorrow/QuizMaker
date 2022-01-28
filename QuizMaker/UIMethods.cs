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

        public static Answer UserAnswerCorrect()
        {                      
            //throw new NotImplementedException();

            Console.WriteLine("Is this answer correct? y/n");
            Answer answer = new Answer();
            answer.isCorrect = Console.ReadLine().ToLower() == "y";
            Console.Clear();
            return answer;
        }

        public static QuestionAndAnswer GetQuestion()
        {
            //throw new NotImplementedException();           

            Console.WriteLine("Enter a multiple choice question");
            QuestionAndAnswer qna = new QuestionAndAnswer();
            qna.question = Console.ReadLine();
            Console.Clear();
            return qna;
        }

        public static Answer GetAnswer()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Enter an Answer");
            Answer answer = new Answer();
            answer.answerString = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Is this answer correct? y/n");          
            answer.isCorrect = Console.ReadLine().ToLower() == "y";
            Console.Clear();
            return answer;
        }

        public static bool anotherQuestion()
        {
            bool exit = false;
            bool anotherQuestion;
            Console.WriteLine("Press 'Enter' to enter another question, press 'any other key' to end quiz building.");
            anotherQuestion = Console.ReadKey().Key == ConsoleKey.Enter; 
            Console.Clear();
            if (!anotherQuestion)
            {
                exit = true;
            }
            return anotherQuestion;
           

            

            

        }


    }
}
