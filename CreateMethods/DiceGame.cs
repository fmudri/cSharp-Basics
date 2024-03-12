class RollDice
{
    static void Main(string[] args)
    {

        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        bool ShouldPlay()
        {
            //This method should retrieve user input and determine if the user wants to play again
            var UserPlays = Console.ReadLine();
            return UserPlays.ToUpper().Trim().Equals("y");
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
                var roll = random.Next(1, 6);
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
    }
}