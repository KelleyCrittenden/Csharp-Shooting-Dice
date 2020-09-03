using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> SmackTalkList = new List<string>()
        {
            "Thou forward unwash'd flirt-gill!",
            "So, so, thou common dog, didst thou disgorge thy glutton bosom.",
            "Come, you are a tedious fool. To the purpose.",
            "We leak in your chimney!",
            "Thou impertinent sheep-biting whey-face!",
            "Thou art a disease that must be cut away."

        };

        public override int Roll()
        {

            int randomTaunt = new Random().Next(SmackTalkList.Count);
            string random = SmackTalkList[randomTaunt];
            Console.WriteLine($"{Name} yells - {random}");

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}