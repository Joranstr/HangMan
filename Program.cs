using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (game.NewGame())
            {
                game.RunOneRound();
            }
            
        }

    }
}
