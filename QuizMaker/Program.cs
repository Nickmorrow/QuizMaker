// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using QuizMaker;




enum QuizMode
{
    newQuiz, 
    loadQuiz
}

namespace QuizMaker
{
    public class Program
    {
        public static void Main()
        {            
            bool quizMaker = true;
            bool startNewQuiz;
            bool buildingQuiz = true;
            bool anotherQuestion;
            bool folderEmpty;
            int score = 0;
            int qnaNum = 1;

            var path = @"E:\Projects\Programming\CSharp\RaketeMentoring\Week11\QuizMaker\UserTests\userTest.xml";

            List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();
            QuestionAndAnswer qna;
            Answer answer;
          
            while (quizMaker)
            {                
                startNewQuiz = UIMethods.NewQuiz();//Welcome message, asks user if they want to start a new quiz or load existing             

                if (startNewQuiz)
                {
                    while (buildingQuiz)
                    {
                        qna = UIMethods.GetQnA(); //asks user to enter question and answers
                        QnAs.Add(qna); // adds question and answers to list

                        anotherQuestion = UIMethods.anotherQuestion(); //asks user if they want to create another question or exit

                        if (anotherQuestion)
                        {
                            buildingQuiz = true;
                        }
                        else
                        {
                            Save(path, QnAs);

                            buildingQuiz = false;
                        }
                    }
                }
                
                if (!startNewQuiz)
                {                   
                    folderEmpty = !File.Exists(path);

                    if (folderEmpty)
                    {
                        UIMethods.FolderEmpty();
                    }
                    else
                    {
                        QnAs = Load(path);

                        qnaNum = 1;
                        score = 0;

                        if (QnAs.Count == 0)
                        {
                            UIMethods.EmptyQuiz();
                        }
                        else
                        {
                            QnAs = Shuffle(QnAs);

                            for (int i = 0; i < QnAs.Count; i++)
                            {
                                qna = QnAs[i];

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

                                qnaNum++;
                            }
                            UIMethods.QuizComplete(QnAs, score);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Deserializes quiz stored in xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<QuestionAndAnswer> Load(string path)
        {
            List<QuestionAndAnswer> QnAs = new List<QuestionAndAnswer>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionAndAnswer>));
            using (FileStream file = File.OpenRead(path))
            {
                QnAs = serializer.Deserialize(file) as List<QuestionAndAnswer>;
            }
            return QnAs;

        }
        /// <summary>
        /// Serializes quiz to xml doc
        /// </summary>
        /// <param name="path"></param>
        /// <param name="QnAs"></param>
        public static void Save(string path, List<QuestionAndAnswer> QnAs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionAndAnswer>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QnAs);
            }
        }
        /// <summary>
        /// Shuffles order of questions in list
        /// </summary>
        /// <param name="toShuffle"></param>
        /// <returns></returns>
        public static List<QuestionAndAnswer> Shuffle(List<QuestionAndAnswer> toShuffle)
        {
            Random rnd = new Random();
            int n = toShuffle.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                QuestionAndAnswer value = toShuffle[k];
                toShuffle[k] = toShuffle[n];
                toShuffle[n] = value;
            }

            return toShuffle;
        }
    }
}










