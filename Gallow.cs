using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    class Gallow
    {
        public void Draw(int wrongGuesses)
        {
            Console.Clear();
            List<string> gallow = GallowReturn(wrongGuesses);

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
            if (wrongGuesses == 1)
            {
                return new List<string>() { " _____", " |   |", " |   O", " |", " |", "_|__", "", "" };
            }

            if (wrongGuesses == 2)
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
    }
}
