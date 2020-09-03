using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = ("Out of my sight! Thou dost infect my eyes");

        public override int Roll()
        {;
            Console.WriteLine($"{Name} yells - {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}