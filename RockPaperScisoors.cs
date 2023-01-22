
const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

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






