Random random = new Random();

int playerScore = 0;
int enemyScore = 0;

Console.WriteLine("Welcome to rock paper scissors!");

while (playerScore != 3 && enemyScore != 3)
{
    Console.WriteLine($"Player score - {playerScore}. Enemy score - {enemyScore}.");
    Console.WriteLine("Please enter 'r' for rock, 'p' for paper or 's' for scissors.");
    string playersChoise = Console.ReadLine();

    int enemyChoise = random.Next(0, 3);

    if (enemyChoise == 0)
    {
        Console.WriteLine("Enemy chooses rock.");
        switch (playersChoise)
        {
            case "r": Console.WriteLine("Tie!");
                break;
            case "p":Console.WriteLine("Player wins this round.");
                playerScore++;
                break;
            case "s": Console.WriteLine("Enemy wins this round.");
                enemyScore++;
                break;
        }
    }
    else if (enemyChoise == 1)
    {
        Console.WriteLine("Enemy chooses paper.");
        switch (playersChoise)
        {
            case "r":
                Console.WriteLine("Enemy wins this round.");
                enemyScore++;
                break;
            case "p":
                Console.WriteLine("Tie!");
                break;
            case "s":
                Console.WriteLine("Player wins this round.");
                playerScore++;
                break;
        }
    }
    else  if(enemyChoise == 2)
    {
        Console.WriteLine("Enemy chooses scissors.");
        switch (playersChoise)
        {
            case "r":
                Console.WriteLine("Player wins this round.");
                playerScore++;
                break;
            case "p":
                Console.WriteLine("Enemy wins this round.");
                enemyScore++;
                break;
            case "s":
                Console.WriteLine("Tie!");
                break;
        }
    }

}
if(playerScore == 3)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}