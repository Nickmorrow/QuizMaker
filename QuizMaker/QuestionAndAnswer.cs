using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuestionAndAnswer
    {
        public string question;
        public List<Answer> Answers = new List<Answer>();
        
        //TODO: Use list of Answer object here


        public override string ToString()
        {
            return $"{question} - {Answers.Count}";
        }
    }
}
