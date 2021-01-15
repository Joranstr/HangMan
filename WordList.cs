using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    class WordList
    {
        private readonly List<string> wordList = new List<string>
        {
            "test", "list", "array","name" 
        };

        public string SelectRandomWord()
        {
            var random = new Random();
            var word = wordList[random.Next(minValue:0,maxValue:wordList.Count-1)];
            return word;
        }
    }
}
