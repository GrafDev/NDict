using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace NDict.Models
{
    public class Vocabulary
    {
        private string title;
        private int countOfWords;
        private List<Word> words;

        static private bool loaded=false;
        public string Title { get => title; set => title = value; }
        public int CountOfWords { get => countOfWords; set => countOfWords = value; }  
        public List<Word> Words { get => words; set => words = value; }


        XmlSerializer formatter = new XmlSerializer(typeof(Vocabulary));
        string nameOfFileXML = "NDict_Dictionary.xml";

        public Vocabulary()
        {
            LoadXML();
        }

        private void LoadXML()
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
                    Console.WriteLine(str);
                    Console.WriteLine("Vocabulary loaded");
                    Console.WriteLine($"Name of dictionary: {newDict.Title}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {

                    loaded = true;
                    Console.WriteLine("");
                    
                }

            }
            
        }

    }
}
