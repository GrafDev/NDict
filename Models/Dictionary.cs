using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    static class Dictionary
    {
        static string title;
        static int countOfWords;
        static List<Word> _words;

        public static List<Word> Words { get => _words; set => _words = value; }

        static public void Loaded()
        {
            Vocabulary vocabulary = new Vocabulary();
            title= vocabulary.Title;
            countOfWords=vocabulary.CountOfWords;
            Words = vocabulary.Words;
        }
    }
}
