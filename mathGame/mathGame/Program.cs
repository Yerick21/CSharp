using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, Player! Welcome to the Math Game!");
Console.WriteLine("You will be given a series of math problems to solve. Let's get started!");

//Array of questions and their corresponding answers
string[] questions =
{
    "What is 5 + 3?",
    "What is 10 - 4?",
    "What is 6 * 7?",
    "What is 20 / 5?"
};

//Array of correct answers corresponding to the questions
int[] answers = { 8, 6, 42, 4 };

//initialize score variable to keep track of correct answers
int score = 0;


//loop through each question, get user input, and check if the answer is correct
for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    string userInput = Console.ReadLine();

    if (userInput != answers[i].ToString())
    {
        Console.WriteLine("Incorrect! The correct answer is: " + answers[i]);
    }
    else
    {
        Console.WriteLine("Correct!");
        score++;
    }
}

Console.WriteLine("Game Over! Your final score is: " + score);