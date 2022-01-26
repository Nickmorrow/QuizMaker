// See https://aka.ms/new-console-template for more information

using QuizMaker;

string yesString = "y";
string noString = "n";
string loadQuiz = "l";
string newQuiz = "n";
string userStartOrLoad;
bool buildingQuiz = true;

List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();


//for (int i = 0; i < 10; i++)
//{
//    var q = new QuestionAndAnswer();
//    q.question = "test";
//    QnAs.Add(q);


//  //  QnAs.Add(q);
//}

//StreamWriter writer = File.CreateText("newfile.txt");

//System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(QnAs.GetType());
//serializer.Serialize(writer, QnAs);


userStartOrLoad = UIMethods.StartOrLoadQuiz();//Welcome message, asks user if they want to start a new quiz or load existing, stores answer

if (userStartOrLoad == newQuiz)
{
    while (buildingQuiz)
    {
        int correctAnswers = 0;
        string isCorrectString = "";
        bool isCorrect = false;

        QuestionAndAnswer qna = new QuestionAndAnswer();//work on method to create question and answers, writes them to xml file
                                                                  //asks user if they want to create another question or if the quiz is complete       
        qna.question = QuizMaker.UIMethods.UserQuestion();

        qna.answers.Add();
 
        

    }






}











