using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameBoard = new GameBoard();
            gameBoard.NewGame();
            

            do
            {
                gameBoard.DrawGallow();
                gameBoard.DrawLetterLine();
                gameBoard.GuessLetter();
                gameBoard.HasWonOrLost();
            } while (gameBoard.ContinueGame);
            
        }

    }
}
