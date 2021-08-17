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
            SetKnobs();
        }
        static internal void SetKnobs()
        {
            int i = 0;
            while (i < countOfKnobs)
            {
                
                _text[i] =( i * 10).ToString();
                i++;
            }
            _text[0] = Dictionary.allLearningWords[0].ToString();
        }
    }
}
