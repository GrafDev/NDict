using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    internal static class Knobs
    {
        static private int countOfKnobs=6;
        static private List<String> _text = new List<String>();
        static private bool Firstlanguage;
        public static List<String> Text { get => _text; set => _text = value; }

        static internal void Loaded()
        {
            
            Firstlanguage = true;
            for (int i=1; i<countOfKnobs; i++)
            {
                string tempStr= Dictionary.Words[i].Language01;
                _text[0] = tempStr;
            }

        }
    }
}
