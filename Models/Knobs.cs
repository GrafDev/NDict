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

        static internal void Loaded()
        {
            SetWordsForKnobs();
        }
        static internal void SetWordsForKnobs()
        {
            int i = 0;
            while (i < countOfKnobs)
            {
                 _text[i] = Firstlanguage? Dictionary.allLearningWords[i].Language1.ToString(): Dictionary.allLearningWords[i].Language2.ToString();
                i++;
            }
        }
    }
}
