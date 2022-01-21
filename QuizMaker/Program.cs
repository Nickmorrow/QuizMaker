// See https://aka.ms/new-console-template for more information

string yesString = "y";
string noString = "n";
string loadQuiz = "l";
string startQuiz = "s";
string userStartOrLoad;

userStartOrLoad = QuizMaker.UIMethods.StartOrLoadQuiz();//Welcome message, asks user if they want to start a new quiz or load existing, stores answer

if (userStartOrLoad == startQuiz)
{      

    QuizMaker.Question questionOne = new QuizMaker.Question();
    
    Console.WriteLine("Enter a multiple choice question");
    questionOne.question = Console.ReadLine();

    Console.WriteLine("Enter answer a.");
    questionOne.a = Console.ReadLine();
    Console.WriteLine("Is this answer correct? y/n");



    Console.WriteLine("Enter answer b.");
    Console.WriteLine("Enter answer c.");
    Console.WriteLine("Enter answer d.");







}











