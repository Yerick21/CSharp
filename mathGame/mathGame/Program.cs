using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, Player! Welcome to the Math Game!");

Console.WriteLine("What is your name?");
string playerName = Console.ReadLine();
Console.WriteLine("Nice to meet you, " + playerName + "!");


Console.WriteLine("You will be given a series of math problems to solve. Press enter to get started.");
Console.ReadLine();

//Array of questions and their corresponding answers
string[] questions =
{
    "What is 5 + 3?\n",
    "What is 10 - 4?\n",
    "What is 6 * 7?\n",
    "What is 20 / 5?\n"
};

//Array of correct answers corresponding to the questions
int[] answers = { 8, 6, 42, 4 };

//initialize score variable to keep track of correct answers
int score = 0;

string playAgain = "yes";

//main game loop that continues until the player chooses to stop playing
while (playAgain == "yes")
{
        Console.WriteLine("Starting a new game...");
        score = 0; // reset score for new game


    //loop through each question, get user input, and check if the answer is correct
    for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);

            //receive user input and validate to ensure it's a number
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            if (userAnswer != answers[i])
            {
                Console.WriteLine("Incorrect! The correct answer is: " + answers[i] + "\n");
            }
            else
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
        }

        Console.WriteLine("Do you want to play again? (yes/no)");
        playAgain = Console.ReadLine().ToLower();
} 

Console.WriteLine("Thanks for playing, " + playerName + "! Your final score is: " + score);
