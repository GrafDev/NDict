using System;
using System.Collections.Generic;
using System.Text;
using NDict.ViewModels;
using NDict.Views.Windows;

namespace NDict.Models
{
    static class NDictionary
    {
        static string title;
        static int countOfWords;
        static List<Word> _words;
        public static List<Word> Words { get => _words; set => _words = value; }

        static public void Loaded()
        {
            Words = new List<Word>();
            Vocabulary vocabulary = new Vocabulary();
            vocabulary.LoadXML();
            title= vocabulary.Title;
            countOfWords=vocabulary.CountOfWords;
            Words = vocabulary.Words;

        }


    }
}
