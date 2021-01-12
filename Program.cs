using System;
using System.Collections.Generic;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordList = new Words();
            var gameBoard = new GameBoard();
            var wordSelector = new Words();
            var word = wordSelector.SelectRandomWord();
            var charArrayOfWord = word.ToCharArray();

            do
            {
                gameBoard.DrawGallow();
                gameBoard.DrawLetterLine(charArrayOfWord);
                gameBoard.GuessLetter(charArrayOfWord);
            } while (true);
            
        }

        
    }
}
