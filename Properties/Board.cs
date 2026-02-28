using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Properties
{
    internal class Board
    {
        private State[,] board = new State[3, 3]; // Create the matrix that represent the tic tac toe board
        private int counter = 1; // Counter to identify if is X or O

        public void SetBoard(int row, int column)
        {
            if (counter % 2 == 0) // If it's even then it's player X turn
            { 
                board[row, column] = State.O;
                counter += 1; // adds one to the counter switching moves between X and O
            }
            else {
                board[row, column] = State.X;
                counter += 1;
            }
        }

        public State[,] GetBoard()
        {
            State[,] allBoard = new State[3, 3];
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                    allBoard[row, column] = board[row, column];
            }
            return allBoard;
        }
    }
}
