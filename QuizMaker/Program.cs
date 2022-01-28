// See https://aka.ms/new-console-template for more information

using QuizMaker;




//enum QuizMode
//{
//    newQuiz,
//    loadQuiz
//}

bool quizMaker = true;
bool startNewQuiz;
bool buildingQuiz = true;
bool anotherQuestion;

List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();
QuestionAndAnswer qna = new QuestionAndAnswer();
Answer answer = new Answer();
List<Answer> answers;
qna.answers = answers = new List<Answer>();

while (quizMaker)
{

    startNewQuiz = UIMethods.NewQuiz();//Welcome message, asks user if they want to start a new quiz or load existing

    if (startNewQuiz)
    {
        while (buildingQuiz)
        {

            qna = UIMethods.GetQuestion(); //asks user to enter question
            
            for (int i = 0; i < 4; i++) //gets 4 answers to question from user, asks whether the answer is correct
            {
                answer = UIMethods.GetAnswer();
                qna.answers.Add(answer);
            }

            QnAs.Add(qna); // adds question and answers to list

            anotherQuestion = UIMethods.anotherQuestion(); //asks user if they want to create another question or exit

            if (anotherQuestion)
            {
                buildingQuiz = true;
            }
            else
            {
                buildingQuiz = false;
                startNewQuiz = false;
            }

        }






    }
}










