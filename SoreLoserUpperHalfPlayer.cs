using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        // overriding Roll so that the player never rolls anything under 4
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(4, DiceSize) + 1;
        }
        // over riding Play so that the player throws an exception if they lose
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int otherRoll = other.Roll();
            int myRoll = Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                // throwing an exception if they player loses
                throw new Exception($"{Name} yells - You cheated!");

            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}