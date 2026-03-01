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

            //Position matrixPosition = new Position();
            //matrixPosition.row = 2;
            //matrixPosition.column = 1;
            //Console.WriteLine(matrixPosition.row);

            //State[,] board = new State[3, 3];
            //for (int row = 0; row < board.GetLength(0); row++)
            //{
            //    for (int column = 0; column < board.GetLength(1); column++)
            //        Console.WriteLine(board[row, column] + " ");
            //    Console.WriteLine();
            //}

            //string moves = Console.ReadLine();
            //int movesWanted = Convert.ToInt32(moves);

            Board boardPosition = new Board();

            for (int a = 1; a < 9 + 1; a++) { // Can make all moves that are requested in the "movesWanted", the moves are all stored in the class!

                State[,] boardFromClass = boardPosition.GetBoard();

                string input = Console.ReadLine();
                int userInput = Convert.ToInt32(input);

                if (userInput >= 1 && userInput <= 3) {  // Uses the user input to select the position on the board
                    if (boardFromClass[0, userInput - 1] == State.Undecided)
                        boardPosition.SetBoard(0, userInput - 1);
                    else{ 
                        Console.WriteLine("You already put in this position");
                        a -= 1;}
                }
                else if (userInput >= 4 && userInput <= 6) {
                    if (boardFromClass[1, userInput - 4] == State.Undecided)
                        boardPosition.SetBoard(1, userInput - 4);
                    else{
                        Console.WriteLine("You already put in this position");
                        a -= 1;
                    }
                }
                else if (userInput >= 7 && userInput <= 9) {
                    if (boardFromClass[2, userInput - 7] == State.Undecided)
                        boardPosition.SetBoard(2, userInput - 7);
                    else { 
                        Console.WriteLine("You already put in this position");
                        a -= 1;
                    }
                }
                else {
                    Console.WriteLine("\nThe TicTacToe Board only work beteewn 1 and 9"); // Avoid something like a "out of range" error that is not reported
                    a -= 1;
                }

                Console.WriteLine();
                
                for (int row = 0; row < boardFromClass.GetLength(0); row++) // This for loop draw a perfect board with all position
                {
                    for (int column = 0; column < boardFromClass.GetLength(1); column++)

                        if (boardFromClass[row, column] == State.Undecided) // Ensures that if the space is empty then print with empty spaces, obeying the grid
                        {
                            if (column < 2)
                            { Console.Write("   |"); }
                            else
                                Console.Write("   ");
                        }
                        else // Prints with the rigth X or O in the rigth position if the space isnt empty
                        {
                            if (column < 2)
                                Console.Write($" {boardFromClass[row, column]} |");
                            else
                                Console.Write($" {boardFromClass[row, column]} ");
                        }
                    if (row < 2)
                        Console.WriteLine("\n---+---+---");
                }
                Console.WriteLine("\n");

                //foreach (State debugging in boardFromClass) // You can uncoment to debbuging if the if statement fails
                //    Console.WriteLine(debugging);
            }  
        }
    }
}
