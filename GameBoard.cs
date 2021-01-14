using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HangMan
{
    class GameBoard
    {
        private int _wrongGuesses = 0;
        private List<string> _correctGuesses;
        public bool ContinueGame = true;
        public char[] WordChars;

        public void DrawGallow()
        {
            Console.Clear();
            List<string> gallow = GallowReturn(_wrongGuesses) ;

            foreach (var gallaowpart in gallow)
            {
                Console.WriteLine(gallaowpart);
            }
        }

        private List<string> GallowReturn(in int wrongGuesses)
        {
            if (wrongGuesses == 0)
            {
                return new List<string>() { " _____", " |   |", " |", " |", " |", "_|__", "", "" };
            }
            if(wrongGuesses == 1)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |", " |", "_|__", "", "" };
            }

            if (wrongGuesses ==2)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |   |", " |", "_|__", "", "" };
            }
            if (wrongGuesses == 3)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |  /|", " |", "_|__", "", "" };
            }
            if (wrongGuesses == 4)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |  /|\\", " |", "_|__", "", "" };
            }
            if (wrongGuesses == 5)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |  /|\\", " |   /", "_|__", "", "" };
            }
            else
            {
                return new List<string>() { " _____", " |   |", " |   O", " |  /|\\", " |   /\\", "_|__", "", "" };
            }

        }

        public void DrawLetterLine()
        {
            for (int i = 0; i < WordChars.Length; i++)
            {
                if (i <_correctGuesses)
                {
                    Console.Write(WordChars[i]);
                }
                else
                {
                    Console.Write("_ ");
                }
                
            }

            Console.WriteLine();
        }

        internal void GuessLetter()
        {
            var guess = Console.ReadLine();
            
            if (!AddLetterIfGeuessedCorrect(guess))
            {
                _wrongGuesses++;
            }
        }

        private void AddLetterIfGeuessedCorrect(string guess)
        {
            var guessedChar = new List<string>();
            
            foreach (var wordChar in WordChars)
            {
                if (wordChar.Equals(guess.ToCharArray()))
                    _correctGuesses.Add(guess);
            }
        }

        public void HasWonOrLost()
        {
            if (_correctGuesses == WordChars.Length)
            {
                Console.Clear();
                Console.WriteLine("Player has won!");
                NewGame();

            }

            if (_wrongGuesses == 6)
            {
                Console.Clear();
                Console.WriteLine($"Player has lost!");
                NewGame();
            }
        }

        public void NewGame()
        {
            Console.WriteLine("Do you wont to start new game? y/n");
            var restartAnswer = Console.ReadLine();
            
            if (restartAnswer == "y")
            {
                _correctGuesses = 0;
                _wrongGuesses = 0;
                GetWordForGame();
                
            }
            if (restartAnswer == "n")
            {
                ContinueGame = false;
            }

            if (restartAnswer== "")
            {
                Console.Clear();
                NewGame();
            }
            
        }

        private void GetWordForGame()
        {
            var wordList = new Words();
            WordChars = wordList.SelectRandomWord();
        }
    }
}
