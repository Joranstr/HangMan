using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    class Words
    {
        private List<string> wordList = new List<string>
        {
            "test", "list", "array","name" 
        };

        public char[] SelectRandomWord()
        {
            var random = new Random();
            var word = wordList[random.Next(minValue:0,maxValue:wordList.Count-1)];
            var wordInChars = word.ToCharArray();
            return wordInChars;
        }
    }
}
