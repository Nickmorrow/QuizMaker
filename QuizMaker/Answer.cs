﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Answer 
    {
        public string answerString;
        public bool isCorrect;

        public override string ToString()
        {
            return $"{answerString} - {isCorrect}";
        }
    }
}
