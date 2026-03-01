using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Properties
{
    internal class Board
    {
        private State[,] board = new State[3, 3]; // Create a multidimensional array, a matrix that represent the tic tac toe board
        private int counter = 1; // Counter to dertermine if it's X or O, if it's odd then the move is X

        public void SetBoard(int row, int column)
        {
            if (counter % 2 == 0) // If it's even then it's player X turn
            { 
                board[row, column] = State.O;
                counter += 1; // adds one to the counter switching moves between X and O
                Console.WriteLine("It's O turn");
            }
            else {
                board[row, column] = State.X;
                counter += 1;
                Console.WriteLine("It's X turn");
            }
        }

        public State[,] GetBoard() // This constructor returns the matrix with all rows and columns
        {
            return board;
        }
    }
}
