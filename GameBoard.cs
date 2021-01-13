using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HangMan
{
    class GameBoard
    {
        private int _wrongGuesses = 0;
        private int _correctGuesses = 0;
        public bool ContinueGame = true;

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

        public void DrawLetterLine(Char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i <_correctGuesses)
                {
                    Console.Write(word[i]);
                }
                else
                {
                    Console.Write("_ ");
                }
                
            }

            Console.WriteLine();
        }

        internal void GuessLetter(Char[] word)
        {
            var guess = Console.ReadLine();
            if (CorrectLetterGuess(word, guess))
            {
                _correctGuesses++;
            }
            else
            {
                _wrongGuesses++;
            }
        }

        private bool CorrectLetterGuess(char[] word, string guess)
        {
            return guess.Equals(word[_correctGuesses].ToString()) ;
        }

        public void HasWonOrLost(char[] word)
        {
            if (_correctGuesses == word.Length)
            {
                Console.Clear();
                Console.WriteLine("Player has won!");
                NewGame();

            }

            if (_wrongGuesses == 6)
            {
                Console.Clear();
                Console.WriteLine("Player has lost!");
                NewGame();
            }
        }

        private void NewGame()
        {
            Console.WriteLine("Do you wont to restart? y/n");
            var restartAnswer = Console.ReadLine();
            if (restartAnswer == "y")
            {
                Console.WriteLine("test1");
                //_correctGuesses = 0;
                //_wrongGuesses = 0;
                
            }
            else if (restartAnswer == "n")
            {
                ContinueGame = false;
            }
            
            
        }
    }
}
