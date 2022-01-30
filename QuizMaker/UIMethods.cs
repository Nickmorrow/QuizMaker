﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class UIMethods
    {
        /// <summary>
        /// Welcome message, asks user if they would like to create a quiz or load a quiz
        /// </summary>
        /// <returns>bool true for start false for load</returns>
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
        /// <summary>
        /// asks user building quiz if the answer to their question is a correct answer
        /// </summary>
        /// <returns>answer object</returns>
        public static Answer UserAnswerCorrect()
        {                      
            //throw new NotImplementedException();

            Console.WriteLine("Is this answer correct? y/n");
            Answer answer = new Answer();
            answer.isCorrect = Console.ReadLine().ToLower() == "y";
            Console.Clear();
            return answer;
        }
        /// <summary>
        /// Asks user to enter a question
        /// </summary>
        /// <returns> QuestionAndAnswer object</returns>
        public static QuestionAndAnswer GetQuestion()
        {
            //throw new NotImplementedException();           

            Console.WriteLine("Enter a multiple choice question");
            QuestionAndAnswer qna = new QuestionAndAnswer();
            qna.question = Console.ReadLine();
            Console.Clear();
            return qna;
        }
        /// <summary>
        /// Asks user to provide an answer to their question
        /// </summary>
        /// <returns> Answer object</returns>
        public static Answer GetAnswer()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Enter an Answer, beginning with A, B, C, or D");
            Answer answer = new Answer();
            answer.answerString = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Is this answer correct? y/n");          
            answer.isCorrect = Console.ReadLine().ToLower() == "y";
            Console.Clear();
            return answer;
        }
        /// <summary>
        /// Asks user if they would like to create another question and answers or exit building quiz
        /// </summary>
        /// <returns>bool true for enter another question false for exit</returns>
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
        /// <summary>
        /// Asks question stores answer
        /// </summary>
        /// <param name="qna"></param>
        /// <param name="qnaNum"></param>
        /// <returns>Answer object</returns>
        public static Answer AskQGetA(QuestionAndAnswer qna, int qnaNum)
        {
            Answer answer = new Answer();
            string userInput;
            bool answeringQuestion = true;

            Console.WriteLine($"Question number{qnaNum} {qna.question}");
            Console.WriteLine($"{qna.answers[0].answerString}");
            Console.WriteLine($"{qna.answers[1].answerString}");
            Console.WriteLine($"{qna.answers[2].answerString}");
            Console.WriteLine($"{qna.answers[3].answerString}");

            while (answeringQuestion)
            {
                userInput = Console.ReadLine().ToUpper();

                //if (userInput == "A")
                //{
                //    answer = qna.answers[0];
                //    answeringQuestion = false;
                //}
                //if (userInput == "B")
                //{
                //    answer = qna.answers[1];
                //    answeringQuestion = false;
                //}
                //if (userInput == "C")
                //{
                //    answer = qna.answers[2];
                //    answeringQuestion = false;
                //}
                //if (userInput == "D")
                //{
                //    answer = qna.answers[3];
                //    answeringQuestion = false;
                //}
                //else
                //{
                //    Console.WriteLine("Please enter either A, B, C, or D");
                //}
                switch (userInput)
                {
                    case "A":
                        answer = qna.answers[0];
                        answeringQuestion = false;
                        break;
                    case "B":
                        answer = qna.answers[1];
                        answeringQuestion = false;
                        break;
                    case "C":
                        answer = qna.answers[2];
                        answeringQuestion = false;
                        break;
                    case "D":
                        answer = qna.answers[3];
                        answeringQuestion = false;
                        break;
                    default:
                        Console.WriteLine("Please enter either A, B, C, or D");
                        answeringQuestion = true;
                        break;
                }                                       
            }

            Console.Clear();
            return answer;

        }
        /// <summary>
        /// Randomly selects Question from list
        /// </summary>
        /// <param name="QnAs"></param>
        /// <returns>QuestionAndAnswer object</returns>
        public static QuestionAndAnswer GetRndQnA(List<QuestionAndAnswer> QnAs)
        {
            Random random = new Random();
            QuestionAndAnswer rndQuestion = new QuestionAndAnswer();
            rndQuestion = QnAs[random.Next(QnAs.Count)];
            return rndQuestion;

        }

        public static void Correct()
        {
            
            Console.WriteLine("Correct! press any key to continue to the next question");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InCorrect(QuestionAndAnswer qna)
        {
            Answer answer= new Answer();
            List<Answer> CorrectAnswers = new List<Answer>();
            
            for (int i = 0; i < qna.answers.Count; i++)
            {
                if (qna.answers[i].isCorrect)
                {
                    CorrectAnswers.Add(qna.answers[i]);
                }
            }
            Console.WriteLine($"Incorrect! the correct answer was {CorrectAnswers} \npress any key to continue to the next question");
            Console.ReadKey();
            Console.Clear();

        }

        public static void QuizComplete(List<QuestionAndAnswer> QnAs, int score)
        {

            Console.WriteLine($"Quiz complete, you got {score} out of {QnAs.Count} correct\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }










    }
}
