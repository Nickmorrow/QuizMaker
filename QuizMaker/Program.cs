﻿// See https://aka.ms/new-console-template for more information
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
                        Load(path, QnAs);

                        qnaNum = 1;

                        if (QnAs.Count == 0)
                        {
                            UIMethods.EmptyQuiz();
                        }
                        else
                        {
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

                                qnaNum++;

                                if (QnAs.Count > 1)
                                {
                                    QnAs.RemoveAt(i);
                                }

                            }
                            UIMethods.QuizComplete(QnAs, score);
                        }
                    }
                }
            }
        }

        public static List<QuestionAndAnswer> Load(string path, List<QuestionAndAnswer> QnAs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionAndAnswer>));
            using (FileStream file = File.OpenRead(path))
            {
                QnAs = serializer.Deserialize(file) as List<QuestionAndAnswer>;
            }
            return QnAs;

        }

        public static void Save(string path, List<QuestionAndAnswer> QnAs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionAndAnswer>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QnAs);
            }
        }
    }
}










