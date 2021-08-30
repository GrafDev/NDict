using System;
using System.Collections.Generic;
using System.Text;
using NDict.ViewModels;
using NDict.Views.Windows;

namespace NDict.Models
{
    static class Dictionary
    {
        static string title;
        static int countOfWords;
        static List<Word> _words;
        public static List<Word> Words { get => _words; set => _words = value; }
        static Dictionary()
        {
        }

        static public void Loaded()
        {
            //var testWindow = new TestViewModel();
            //testWindow.TestBlock = "1";
            Vocabulary vocabulary = new Vocabulary();
            //title= vocabulary.Title;
            //countOfWords=vocabulary.CountOfWords;
            //Words = vocabulary.Words;

            var words = new List<Word>();
            var word = new Word();
            word.Id = 2;
            word.Language01 = "01";
            word.Language02 = "02";
            words.Add(word);
            
            //_word[0].Language01 = "Hi";
            //_word[0].Language02 = "Првиет"; 
        }


    }
}
