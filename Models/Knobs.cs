using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    internal static class Knobs
    {
        static private int countOfKnobs=6;
        static private string[] _text = new String[countOfKnobs];
        static private bool Firstlanguage = true;
        public static string[] Text { get => _text; set => _text = value; }

        static internal void SetKnobs()
        {
            int i = 0;
            foreach (Word word in Dictionary.allLearningWords)
            {
                _text[i] = Firstlanguage ? word.Language1: word.Language2;
                i++;
            }
        }
    }
}
