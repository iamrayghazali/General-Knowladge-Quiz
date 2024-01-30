using System.IO;
using System.Text;
using System.Linq;


Console.WriteLine("\tWelcome to the General Knowledge Quiz!\n");
Console.WriteLine("\t\tYou will answer 20 questions, and see how many you get right. ");
Console.WriteLine("\t\tYou can choose A, B or C by typing the letters in.");
Console.WriteLine("\t\tIMPORTANT!");

Console.WriteLine("\t\tThere is only one correct answer. ");


Console.WriteLine("Let's start! ");

//made a list
List<Questions> questionsList = new List<Questions>();
//reading in the file, made sure to be able to change the file easly if needed
string [] fileName = File.ReadAllLines("Questions.csv");

//for loop, starting from 1, so that the first line dose not show
for (int i = 1; i < fileName.Length; i++)
{
    //storing everything with the help of the "Questions.cs" -class
    string[] line = fileName[i].Split(';');
    string question = line[0];
    string optionA = line[1];
    string optionB = line[2];
    string optionC = line[3];
    string answer = line[4];
    //adding to the list each time
    questionsList.Add(new Questions(question, optionA, optionB, optionC, answer));
}

int currentScore = 0;
int questionCounter = 1;
//going through all the questions in the file
foreach (var item in questionsList)
    {
    //printing the questions and options
    Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"QUESTION {questionCounter}\n");

        Console.WriteLine($"\t {item.Question} \n");

        Console.WriteLine($"\t A: {item.OptionA}");
        Console.WriteLine($"\t B: {item.OptionB}");
        Console.WriteLine($"\t C: {item.OptionC} ");

        Console.WriteLine("\t\nEnter your answer:");
        string currentUserAnswer;
    bool notCorrectInput;
    //do while cycle to make sure not to go to the next question with a wrong input
    do
    {
        currentUserAnswer = Convert.ToString(Console.ReadLine().ToUpper());
        //answer validity test
        if (currentUserAnswer != "A" && currentUserAnswer != "B" && currentUserAnswer != "C")
        {
            Console.WriteLine("\t Wrong input! Enter a, b or c.");
            Console.WriteLine("\t\nEnter your answer:");
            notCorrectInput = true;
        }
        else
        {
            notCorrectInput = false;
        }
    } while (notCorrectInput);


        //checking if the given answer is correct
            if (currentUserAnswer==item.Answer)
            {
                currentScore++;
                Console.WriteLine("\t\t\tCORRECT answer!");
                Console.WriteLine($"\t\t\t\tYour current score: {currentScore}");
                 questionCounter++;
            }
            else
            {
                Console.WriteLine("\t\t\tWRONG answer!");
                Console.WriteLine($"\t\tThe correct answer is: {item.Answer} \n");
                Console.WriteLine($"\t\t\t\tYour current score: {currentScore}");
                questionCounter++;
             }
            if (questionCounter == 21)
            {
                    Console.WriteLine("\n\n\t\tCongratulations! You finished the Quiz!");
                    Console.WriteLine($"\t\tYour score is {currentScore}/20");
            }

}
Console.WriteLine("Press any key to exit!");
Console.ReadKey();



