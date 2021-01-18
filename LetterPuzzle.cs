using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangMan
{
    class LetterPuzzle
    {
        private string _correctLetters;
        private char[] _guessedLetters;
        public int WrongGuesses { get; private set; }
        public bool HasWon => _correctLetters == new string(_guessedLetters);

        public LetterPuzzle(string correctLetters)
        {
            _correctLetters = correctLetters;
            _guessedLetters = Enumerable.Repeat('_', correctLetters.Length).ToArray();
        }
        public void DrawLetterLine()
        {
            // Lagde For løkke for å dele opp orde så det syns hvor mange bokstaver som er i orde
            for (int i = 0; i < _guessedLetters.Length; i++)
            {
                Console.Write(_guessedLetters[i]=='_'? _guessedLetters[i]+' ': _guessedLetters[i]);
                //if (_guessedLetters[i]== '_')
                //{
                //    //Console.Write(' ');
                //}
            }
            Console.WriteLine();
        }
        
        internal void Guess(char guess)
        {
            var hasMatch = false;
            
            for (int i = 0; i < _correctLetters.Length; i++)
            {
                
                if (_correctLetters[i] == guess)
                {
                    _guessedLetters[i] = guess;
                    hasMatch = true;
                }
            }

            if (!hasMatch)
            {
                WrongGuesses++;
            }
        }

        public void ShowHasWonOrLost()
        {
            if (HasWon || WrongGuesses== 6)
            {
                Console.WriteLine(HasWon ? "Player has won" : "Player Has lost");
            }
        }
    }
}
