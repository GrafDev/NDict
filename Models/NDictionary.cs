using System;
using System.Collections.Generic;
using System.Text;
using NDict.ViewModels;
using NDict.Views.Windows;
using System.IO;
using System.Xml.Serialization;
using NDict.ViewModels;

namespace NDict.Models
{
    static class NDictionary
    {
        static string title;
        static int countOfWords;
        static List<Word> _words;

        public static string Title { get => title; set => title = value; }
        public static List<Word> Words { get => _words; set => _words = value; }

        private static XmlSerializer formatter = new XmlSerializer(typeof(Vocabulary));
        private static string nameOfFileXML = "NDict_Dictionary.xml";


        static public void Loaded()
        {
            Words = new List<Word>();
            LoadXML();
            ShowWords();
        }

        static void LoadXML()
        {
            using (FileStream fs = new FileStream(nameOfFileXML, FileMode.OpenOrCreate))
            {
                Vocabulary _vocabulary = (Vocabulary)formatter.Deserialize(fs);
                title = _vocabulary.title;
                countOfWords = _vocabulary.CountOfDict;
                Words = _vocabulary.words;
            }
        }
        static private void ShowWords()
        {
            string str = "";
            foreach (Word word in Words)
            {
                str = $"{str} {word.Id}, {word.Language01}, {word.Language02} \n";
            }
            App.TestVM.TestBlock = str;
        }

    }
}
