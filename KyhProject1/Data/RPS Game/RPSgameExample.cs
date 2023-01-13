using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.RPS_Game
{
    public class RPSgameExample
    {
        class Game
        {
            private static readonly string[] _choices = { "rock", "paper", "scissors" };
            private static readonly Random _random = new Random();

            public string Play(string player1Choice)
            {
                string player2Choice = _choices[_random.Next(0, 3)]; // AI makes a random choice

                if (player1Choice == player2Choice)
                    return "Tie";
                if (player1Choice == "rock" && player2Choice == "scissors")
                    return "Player 1 wins";
                if (player1Choice == "rock" && player2Choice == "paper")
                    return "Player 2 wins";
                if (player1Choice == "scissors" && player2Choice == "rock")
                    return "Player 2 wins";
                if (player1Choice == "scissors" && player2Choice == "paper")
                    return "Player 1 wins";
                if (player1Choice == "paper" && player2Choice == "rock")
                    return "Player 1 wins";
                if (player1Choice == "paper" && player2Choice == "scissors")
                    return "Player 2 wins";

                return "Invalid choice";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Game game = new Game();
                Console.WriteLine("Player 1 choice: ");
                string player1Choice = Console.ReadLine();
                Console.WriteLine("AI choice: ");
                string player2Choice = game.Play(player1Choice);
                Console.WriteLine(player2Choice);
                Console.WriteLine(game.Play(player1Choice));
                Console.ReadKey();
            }
        }

    }
}
