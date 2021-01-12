using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    class GameBoard
    {
        private int WrongGuesses = 0;
        private int CorrectGuesses = 0;
        public void DrawGallow()
        {
            Console.Clear();
            List<string> gallow = GallowReturn(WrongGuesses) ;

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
            foreach (var letter in word)
            {
                Console.Write(letter);
                //Console.Write("_ ");
            }

            Console.WriteLine();
        }

        internal void GuessLetter(Char[] word)
        {
            var guess = Console.ReadLine();
            if (!GuesedCorrectLetter(word, guess))
            {
                WrongGuesses++;
                //DrawNextHangManPart();
            }
            else
            {
                CorrectGuesses++;
            }
        }

        private bool GuesedCorrectLetter(char[] word, string guess)
        {
            return guess.Equals(word[CorrectGuesses].ToString()) ;
        }

        private void DrawNextHangManPart()
        {
            throw new NotImplementedException();
        }

    }
}
