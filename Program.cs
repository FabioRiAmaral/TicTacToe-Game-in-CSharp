using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Properties;

namespace TicTacToe
{
    enum State { Undecided, X, O };
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Tic Tac Toe!! (aka Jogo da VEIA)\n\n" +
                              "   |   |   \n" +
                              "---+---+---\n" +
                              "   |   |   \n" +
                              "---+---+---\n" +
                              "   |   |   \n" +
                              "\nChoose a space to start to play!");

            Position matrizPosition = new Position();
            matrizPosition.row = 2;
            matrizPosition.column = 1;
            Console.WriteLine(matrizPosition.row);

            //State[,] board = new State[3, 3];
            //for (int row = 0; row < board.GetLength(0); row++)
            //{
            //    for (int column = 0; column < board.GetLength(1); column++)
            //        Console.WriteLine(board[row, column] + " ");
            //    Console.WriteLine();
            //}

            //string moves = Console.ReadLine();
            //int movesWanted = Convert.ToInt32(moves);

            Board test = new Board();

            for (int a = 1; a < 9 + 1; a++) { // Can make all moves that are requested in the "movesWanted", the moves are all stored in the class!

                int userInput = a;

                if (userInput >= 1 && userInput <= 3) // Uses the user input to select the position on the board
                    test.SetBoard(0, userInput - 1);
                else if (userInput >= 4 && userInput <= 6)
                    test.SetBoard(1, userInput - 4);
                else if (userInput >= 7 && userInput <= 9)
                    test.SetBoard(2, userInput - 7);
                else
                    Console.WriteLine("\nThe TicTacToe Board only work beteewn 1 and 9"); // Avoid a "out of range" error, the board only have 9 slots

            }

            State[,] boardFromClass = test.GetBoard();

            for (int row = 0; row < boardFromClass.GetLength(0); row++)
            {
                for (int column = 0; column < boardFromClass.GetLength(1); column++)
                    Console.WriteLine(boardFromClass[row, column] + " ");
                Console.WriteLine();
            }
        }
    }
}
