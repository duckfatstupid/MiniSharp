int wins = 0;
int losses = 0;
int ties = 0;

Random random = new Random();
String[] choices = { "Rock", "Paper", "Scissors" };
do
{
    Console.WriteLine("\n\nRock-Paper-Scissors Game!");
    Console.Write("Please enter your choice [Rock/Paper/Scissors]:");

    String userChoice = Console.ReadLine();
    String computerChoice = choices[random.Next(choices.Length)];

    if (userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors")
    {
        Console.WriteLine("You chose: " + userChoice);
        Console.WriteLine("Computer chose: " + computerChoice);
        if (userChoice == computerChoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("It's a tie!"); Console.ResetColor(); ties++;
        }
        else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                 (userChoice == "Paper" && computerChoice == "Rock") ||
                 (userChoice == "Scissors" && computerChoice == "Paper"))
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You win!"); Console.ResetColor(); wins++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You lose!"); Console.ResetColor(); losses++;
        }

        Console.Write("\nDo you want to play again [y/n]: ");
        String playAgain = Console.ReadLine();
        if (playAgain.ToLower() != "y")
        {
            break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Invalid choice, please try again."); Console.ResetColor();
    }
}
while (true);

Console.Clear();
Console.WriteLine("Good bye!\nGame Information:\nWins: " + wins + "\nLosses: " + losses + "\nTies: " + ties);
Console.WriteLine("Thank you for playing!");
Console.ReadKey();