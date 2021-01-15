using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HangMan
{
    class Game
    {
        private readonly WordList _wordListList;
        private LetterPuzzle _letterPuzzle;
        private Gallow _gallow;

        public Game()
        {
            _gallow = new Gallow();
            _wordListList = new WordList();
        }

        public void RunOneRound()
        {
            while (_letterPuzzle.WrongGuesses < 6 && !_letterPuzzle.HasWon)
            {
                _gallow.Draw(_letterPuzzle.WrongGuesses);
                _letterPuzzle.Draw();
                var guessStr = Console.ReadLine();
                
                if (!guessStr.Equals(""))
                {
                    var guess = guessStr[0];
                    _letterPuzzle.Guess(guess);
                }
            }
            _gallow.Draw(_letterPuzzle.WrongGuesses);
            _letterPuzzle.Draw();
            _letterPuzzle.ShowHasWonOrLost();
        }

        public bool NewGame()
        {
            Console.WriteLine("Do you wont to start new game? y/n");
            var restartAnswer = Console.ReadLine();
            
            while (restartAnswer != "y" && restartAnswer !="n")
            {
                Console.Clear();
                Console.WriteLine("Do you wont to start new game? y/n");
                restartAnswer = Console.ReadLine();
            }

            if (restartAnswer == "n") return false;
            _letterPuzzle = new LetterPuzzle(_wordListList.SelectRandomWord());
            return true;
        }
    }
}
