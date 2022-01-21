// See https://aka.ms/new-console-template for more information

string yesString = "y";
string noString = "n";
string loadQuiz = "l";
string newQuiz = "n";
string userStartOrLoad;

userStartOrLoad = QuizMaker.UIMethods.StartOrLoadQuiz();//Welcome message, asks user if they want to start a new quiz or load existing, stores answer

if (userStartOrLoad == newQuiz)
{      

    QuizMaker.Question questionOne = new QuizMaker.Question();//work on method to create question and answers, writes them to xml file
                                                              //asks user if they want to create another question or if the quiz is complete
    
    Console.WriteLine("Enter a multiple choice question");
    questionOne.question = Console.ReadLine();

    Console.WriteLine("Enter answer a.");
    questionOne.a = Console.ReadLine();
    Console.WriteLine("Is this answer correct? y/n");



    Console.WriteLine("Enter answer b.");
    Console.WriteLine("Enter answer c.");
    Console.WriteLine("Enter answer d.");







}











