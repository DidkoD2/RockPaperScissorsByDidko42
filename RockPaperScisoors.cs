
const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

while (true)
{
    Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors:");
    string playerMove = Console.ReadLine();

    if (playerMove == "r" || playerMove == "rock")
    {
        playerMove = rock;
    }
    else if (playerMove == "p" || playerMove == "paper")
    {
        playerMove = paper;
    }
    else if (playerMove == "s" || playerMove == "scissors")
    {
        playerMove = scissors;
    }
    else
    {
        Console.WriteLine("Invalid Input. Try Again...");
    }

    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);
    Random randomNumber = new Random();
    string computerMove = "";

    switch (computerRandomNumber)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = paper;
            break;
        case 3:
            computerMove = scissors;
            break;
    }

    Console.WriteLine($"The computer chose {computerMove}");

    if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
    {
        Console.WriteLine("You win.");
    }
    else if ((playerMove == rock && computerMove == rock) || (playerMove == scissors && computerMove == scissors) || (playerMove == paper && computerMove == paper))
    {
        Console.WriteLine("This game was a draw.");
    }
    else
    {
        Console.WriteLine("You lose.");
    }

    Console.WriteLine("Type [yes] to Play Again or [no] to quit");
    string restartTheGame = Console.ReadLine();
    if (restartTheGame == "no")
    {
        return;
    }
}






