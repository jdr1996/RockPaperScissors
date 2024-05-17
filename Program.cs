using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

// Initialize Variables
string player1Choice, player2Choice, computerChoice;
bool playAgain = true;

// Random number generator for AI choice
Random random = new Random();

while (playAgain)
{
    // Get player1's choice
    Console.WriteLine("Enter Rock, Paper, or Scissors" + Environment.NewLine);
    player1Choice = Console.ReadLine().ToUpper();
    
    // Generate AI's choice
    int computerRandomChoice = random.Next(1, 4);
    switch (computerRandomChoice)
    {
        case 1:
            computerChoice = "ROCK";
            break;
        case 2:
            computerChoice = "PAPER";
            break;
        case 3:
        default:
            computerChoice = "SCISSORS";
            break;
    }

    // Display choices
    Console.WriteLine($"You chose: {player1Choice}" + Environment.NewLine + $"AI chose: {computerChoice}" + Environment.NewLine);

    // Determine the winner
    if (player1Choice == computerChoice)
    {
        Console.WriteLine("It's a tie!" + Environment.NewLine);
    }
    else if ((player1Choice == "ROCK" && computerChoice == "SCISSORS") ||
              (player1Choice == "PAPER" && computerChoice == "ROCK") ||
              (player1Choice == "SCISSORS" && computerChoice == "PAPER"))

    {
        Console.WriteLine("You win!" + Environment.NewLine);
    }

    else if ((player1Choice == "ROCK" && computerChoice == "PAPER") ||
             (player1Choice == "PAPER" && computerChoice == "SCISSORS") ||
             (player1Choice == "SCISSORS" && computerChoice == "ROCK"))
    {
        Console.WriteLine("You lose!" + Environment.NewLine);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors" + Environment.NewLine);
        continue;
    }

    // Ask to play again
    Console.WriteLine("Do you want to play again? (YES/NO)?");
    string response = Console.ReadLine().ToUpper();
    playAgain = (response.ToUpper() == "YES");
    Console.WriteLine();
}
// End the game
Console.WriteLine("Thanks for playing!" + Environment.NewLine);