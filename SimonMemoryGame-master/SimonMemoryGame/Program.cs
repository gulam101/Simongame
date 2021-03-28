using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonMemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SimonGame game = new SimonGame();

            while (!game.GameOver)
            {
                displayCurrentRound(game);
                Colors color;
                do
                {
                    Console.WriteLine("Enter color: ");
                    string colorAsString = Console.ReadLine();
                    color = StringToColorConverter.Convert(colorAsString);

                } while (game.MakeGuess(color));
            }

            Console.WriteLine("Game over");
        }
        private static void displayCurrentRound(SimonGame game)
        {
            Console.Clear();
            foreach (Colors color in game.Colors)
            {
                Console.WriteLine("Round " + game.Colors.Count+": \n");

                System.Threading.Thread.Sleep(1000);

                switch (color)
                {
                    case Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                Console.WriteLine(color);

                System.Threading.Thread.Sleep(1000);

                Console.Clear();
                Console.ResetColor();
            }
            Console.WriteLine("Round " + game.Colors.Count + ": \n");
        }
    }
}
