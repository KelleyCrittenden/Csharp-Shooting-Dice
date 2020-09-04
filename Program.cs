using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating new players
            SmackTalkingPlayer player1 = new SmackTalkingPlayer();
            player1.Name = "Smack Talker";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "One Higher";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            HumanPlayer player3 = new HumanPlayer();
            player3.Name = "Human";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer player4 = new CreativeSmackTalkingPlayer();
            player4.Name = "Creative Smack Talker";

            player4.Play(player3);

            Console.WriteLine("-------------------");

            SoreLoserPlayer player5 = new SoreLoserPlayer();
            player5.Name = "Sore Loser Player";
            // catching the exception
            try
            {
                player5.Play(player4);
            }
            catch
            {
                Console.WriteLine($"You cheated!");
            }

            Console.WriteLine("-------------------");

            UpperHalfPlayer player6 = new UpperHalfPlayer();
            player6.Name = "Upper Half Player";

            player6.Play(player5);

            Console.WriteLine("-------------------");
            SoreLoserUpperHalfPlayer player7 = new SoreLoserUpperHalfPlayer();
            player7.Name = "Sore Loser Upper Half Player";
            // catching the exception
            try
            {

                player7.Play(player6);
            }
            catch
            {
                Console.WriteLine($"You cheated!");
            }

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            // creating a list of players
            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                player4,
                player5,
                player6,
                player7,
                large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];

                // adding catch just incase any exceptions happen
                try
                {
                    player1.Play(player2);
                }
                catch
                {
                    Console.WriteLine($"You cheated!");
                }
            }
        }
    }
}