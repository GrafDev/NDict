using System;
using System.Collections.Generic;
using System.Text;
using NDict.ViewModels;
using NDict.Views.Windows;
using System.IO;
using System.Xml.Serialization;
using NDict.Services;

namespace NDict.Models
{
    static class NDictionary
    {
        static string title;
        public static string Title { get => title; set => title = value; }
        

        static List<Word> _words;
        public static List<Word> Words { get => _words; set => _words = value; }

        static public int countOfWords;

        private static XmlSerializer formatter = new XmlSerializer(typeof(Vocabulary));
        private static string nameOfFileXML = "NDict_Dictionary.xml";


        static public void Loaded()
        {            
            Words = LoadXML();
            //Tests.ShowWindow();
            //Tests.GetLearningWordDB();
            //Tests.TextError(_words.Count.ToString());
        }

        static List<Word> LoadXML()
        {
            var _words = new List<Word>();
            using (FileStream fs = new FileStream(nameOfFileXML, FileMode.OpenOrCreate))
            {
                Vocabulary _vocabulary = (Vocabulary)formatter.Deserialize(fs);
                title = _vocabulary.title;
                countOfWords = _vocabulary.CountOfDict;
                _words = _vocabulary.words;                
            }
            return _words;
        }      

    }
}
