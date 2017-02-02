using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock-Paper-Scissors Game";
            Console.WriteLine("Welcome to Rock-Paper-Scissors Game");
            Console.WriteLine("Press <ESC> to Exit");
            Console.WriteLine("Press <Enter> to Start");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                StartGame();
            }

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                EndGame();
            }

        }
        public static string player1;
        public static string player2;
        public static void StartGame()
        {
            Console.WriteLine("The Game is Started");
            Console.WriteLine("Enter Player 1 Name");
            player1 = Console.ReadLine();

            Console.WriteLine("Enter Player 2 Name");
            player2 = Console.ReadLine();


            Console.WriteLine("Player 1 Choose a Shape (Rock, Paper, Scissor)");
            string player1_Shape = Console.ReadLine().ToLower();
            Console.WriteLine("Player 2 Choose an Shape");
            string player2_Shape = Console.ReadLine().ToLower();

            FindWinner(player1_Shape, player2_Shape);

        }
        public static void FindWinner(string player1_Shape, string player2_Shape)
        {
            if (player1_Shape == "rock" && player2_Shape == "paper")
            {
                Console.WriteLine(player2 + " WON");
            }
            else if (player1_Shape == "rock" && player2_Shape == "scissor")
            {
                Console.WriteLine(player1 + " WON");
            }
            else if (player1_Shape == "paper" && player2_Shape == "scissor")
            {
                Console.WriteLine(player2_Shape + " WON");
            }
            else if (player1_Shape == "paper" && player2_Shape == "rock")
            {
                Console.WriteLine(player2_Shape + " WON");
            }
            else if (player1_Shape == "scissor" && player2_Shape == "paper")
            {
                Console.WriteLine(player2_Shape + " WON");
            }
            else if (player1_Shape == "scissor" && player2_Shape == "rock")
            {
                Console.WriteLine(player2_Shape + " WON");
            }
            else if (player1_Shape == player2_Shape)
            {
                Console.WriteLine("Its a tie!");
            }
        }
        public static void EndGame()
        {
            Environment.Exit(0);
        }
    }

}
