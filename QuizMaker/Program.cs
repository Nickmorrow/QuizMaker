// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
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
bool answerCorrect;
int score = 0;
int qnaNum = 1;

XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionAndAnswer>));
var path = @"E:\Projects\Programming\C#\Rakete Mentoring\Week 11\QuizMaker\UserTests\userTest.xml";

Random QnASelector = new Random();

List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();
QuestionAndAnswer qna = new QuestionAndAnswer();
Answer answer = new Answer();
List<Answer> answers = new List<Answer>(); 
qna.answers = answers;

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
                using (FileStream file = File.Create(path))
                {
                    serializer.Serialize(file, QnAs);
                }
           
                buildingQuiz = false;
                startNewQuiz = false;
            }
        }
    }
    if (!startNewQuiz)
    {

        using (FileStream file = File.OpenRead(path))
        {
            QnAs = serializer.Deserialize(file) as List<QuestionAndAnswer>;
        }

        for (int i = 0; i < QnAs.Count; i++)
        {
            qna = UIMethods.GetRndQnA(QnAs);
            answer = UIMethods.AskQGetA(qna, qnaNum);
            if (answer.isCorrect)
            {
                score++;
                UIMethods.Correct();
            }
            else
            {
                UIMethods.InCorrect(qna);
            }        
        }
        UIMethods.QuizComplete(QnAs, score);

    }

}











