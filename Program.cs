using System;

int playerPoints = 0;
int computerPoints = 0;

Console.WriteLine("Dice Game\n");
Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
Console.WriteLine("where you will each roll a 6-sided dice, and the player");
Console.WriteLine("with the highest dice value will win the round. The player");
Console.WriteLine("who wins the most rounds wins the game. Good luck!");
Console.WriteLine("\nPress any key to start...");

Console.ReadKey(true);
Console.WriteLine();
Console.WriteLine();

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"Round {i}");
    int computer = Random.Shared.Next(1, 7);
    int player = Random.Shared.Next(1, 7);

    Console.WriteLine($"Rival rolled a {computer}");
    Console.WriteLine("Press any key to roll the dice...");
    Console.ReadKey(true);
    Console.WriteLine($"You rolled a {player}");

    if (computer > player)
    {
        computerPoints++;
        Console.WriteLine("The Rival won this round.");
    }
    else if (player > computer)
    {
        playerPoints++;
        Console.WriteLine("You won this round.");
    }

    Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {computerPoints}");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey(true);

    Console.WriteLine();
}

Console.WriteLine("Game over.");
Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {computerPoints}");
if (playerPoints > computerPoints)
{
    Console.WriteLine("You won!");
}
else if (computerPoints > playerPoints)
{
    Console.WriteLine("You lost!");
}
else
{
    Console.WriteLine("This game was a draw!");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();