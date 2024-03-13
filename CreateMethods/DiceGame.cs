class RollDice
{
    static void Main(string[] args)
    {

        //MY SOLUTION
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        bool ShouldPlay()
        {
            //This method should retrieve user input and determine if the user wants to play again
            string userPlays = Console.ReadLine();
            return userPlays.ToUpper().Trim().Equals("y");
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                /*The random target number between 1 and 5 roll: 
                The result of a random six-sided dice roll
                */

                var target = random.Next(1, 6);
                var roll = random.Next(1, 7);
                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");

                if (roll > target)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
                Console.WriteLine("\nPlay again? (Y/N)");
                play = ShouldPlay();
            }
        }

        /*
        MICROSOFT SOLUTION
        Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}
        */
    }
}