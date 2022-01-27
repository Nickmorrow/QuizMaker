// See https://aka.ms/new-console-template for more information

using QuizMaker;




//enum QuizMode
//{
//    newQuiz,
//    loadQuiz
//}




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

bool startNewQuiz = false;
bool buildingQuiz = true;


startNewQuiz = UIMethods.NewQuiz();//Welcome message, asks user if they want to start a new quiz or load existing, stores answer

if (startNewQuiz)
{
    while (buildingQuiz)
    {        

        List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();
        QuestionAndAnswer qna = new QuestionAndAnswer();//work on method to create question and answers, writes them to xml file
        Answer answer = new Answer();                                                         //asks user if they want to create another question or if the quiz is complete       
        

        
 
        

    }






}











