using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using NDict.ViewModels;

namespace NDict.Models
{
    public class Vocabulary
    {
        private string title;
        private int countOfWords;
        private List<Word> words;

        public string Title { get => title; set => title = value; }
        public int CountOfWords { get => countOfWords; set => countOfWords = value; }  
        public List<Word> Words { get => words; set => words = value; }


        XmlSerializer formatter = new XmlSerializer(typeof(Vocabulary));
        string nameOfFileXML = "NDict_Dictionary.xml";

        public Vocabulary()
        {
                           
        }

        public void LoadXML()
        {
            
            using (FileStream fs = new FileStream(nameOfFileXML, FileMode.OpenOrCreate))
            {
                try {
                    Vocabulary newDict = (Vocabulary)formatter.Deserialize(fs);
                    string str = "";
                    foreach (Word word in newDict.words)
                    {
                        str = $"{str} ID={word.Id}, russian: {word.Language01}, english:{word.Language02} \n";
                    }
                    title = newDict.Title;
                    countOfWords = newDict.CountOfWords;
                    words = newDict.Words;
                    str = str + $"Vocabulary loaded Name of dictionary: {newDict.Title}";
                    App.TestVM.TestBlock = str;
                }
                catch (Exception e)
                {
                    App.TestVM.TestBlock = $"Exception: {e.Message}";
                }
                finally
                {

                    App.TestVM.TestBlock= "------";

                }

            }
            
        }

    }
}
