using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            // Prompting the user to enter a numer, the number is entered as a string in the read line, parsed into and integer
            Console.WriteLine("What's your lucky number?");
            return int.Parse(Console.ReadLine());
        }
    }
}