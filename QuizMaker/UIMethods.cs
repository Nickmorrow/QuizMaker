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
            string Lstring = "l";
            string Sstring = "s";

            Console.WriteLine("***Welcome to QuizMaker!***\n");
            Console.WriteLine("Press 'L' to load an existing quiz, press 'S' to start a new quiz.\n");

            do
            {
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer != Lstring && userAnswer != Sstring)
                {
                    Console.WriteLine("Please enter either 'L' or 'S.'");
                }
                
            } while (userAnswer != Lstring && userAnswer != Sstring);
            
            Console.Clear();

            return userAnswer;
        }


    }
}
