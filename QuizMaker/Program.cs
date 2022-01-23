// See https://aka.ms/new-console-template for more information

string yesString = "y";
string noString = "n";
string loadQuiz = "l";
string newQuiz = "n";
string userStartOrLoad;
bool buildingQuiz = true;

userStartOrLoad = QuizMaker.UIMethods.StartOrLoadQuiz();//Welcome message, asks user if they want to start a new quiz or load existing, stores answer

if (userStartOrLoad == newQuiz)
{
    while (buildingQuiz)
    {
        int correctAnswers = 0;
        string isCorrectString = "";
        bool isCorrect = false;

        QuizMaker.Question question = new QuizMaker.Question();//work on method to create question and answers, writes them to xml file
                                                                  //asks user if they want to create another question or if the quiz is complete       
        question.question = QuizMaker.UIMethods.UserQuestion();
        
        question.answerA = "A."+ QuizMaker.UIMethods.UserAnswer();
        isCorrectString = QuizMaker.UIMethods.UserAnswerCorrect();
        isCorrect = isCorrectString == yesString;
        if (isCorrect)
        {
            correctAnswers++;
            question.correctAnswer = question.answerA;           

        }

        question.answerB = "B." + QuizMaker.UIMethods.UserAnswer();
        isCorrectString = QuizMaker.UIMethods.UserAnswerCorrect();
        isCorrect = isCorrectString == yesString;
        if (isCorrect)
        {
            correctAnswers++;
            question.correctAnswer = question.answerB;
            if (correctAnswers > 1)
            {
                question.correctAnswer = question.correctAnswer + question.answerB;
            }

        }

        question.answerC = "C." + QuizMaker.UIMethods.UserAnswer();
        isCorrectString = QuizMaker.UIMethods.UserAnswerCorrect();
        isCorrect = isCorrectString == yesString;
        if (isCorrect)
        {
            correctAnswers++;
            question.correctAnswer = question.answerC;
            if (correctAnswers > 1)
            {
                question.correctAnswer = question.correctAnswer + question.answerC;
            }

        }

        question.answerD = "D." + QuizMaker.UIMethods.UserAnswer();
        isCorrectString = QuizMaker.UIMethods.UserAnswerCorrect();      
        isCorrect = isCorrectString == yesString;
        if (isCorrect)
        {
            correctAnswers++;
            question.correctAnswer = question.answerD;
            if(correctAnswers > 1)
            {
                question.correctAnswer = question.correctAnswer + question.answerD;
            }            
        
        }

    }






}











