using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using NDict.ViewModels;
using NDict.Services;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace NDict.Models
{
    internal static  class OldDictionary
    {
        //static public string title;
        //static public string[] dictionaryFromFile;
        //static public int CountOfAllWords;
        //static public List<Word> allLearningWords;
        //static public string TestOfArray;

        //static internal void Loaded()
        //{
        //    allLearningWords = new List<Word>();
        //    //GetDictionaryFromResouce();
            
        //}
  
        //static private void SetArrayOfWords(string[] _dictionary)
        //{

        //    foreach (string str in _dictionary)
        //    {                
        //        var word = new Word();                
        //        var tempString = str.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
        //        word.Id = Convert.ToInt32(tempString[0]);
        //        word.Language01 = tempString[1];
        //        word.Language02 = tempString[2];
        //        allLearningWords.Add(word);
        //        //TestOfArray = Utils.ConvertArrayOfWordToString(allLearningWords);
        //        TestOfArray = allLearningWords.Count.ToString();
        //    }
        //}

        //static void TestXML()
        //{
        //    string nameOfFileXML = "NDict_Dictionary.xml";
        //    // объект для сериализации
        //    Vocabulary dict = new Vocabulary();
        //    Console.WriteLine("Объект создан");

        //    // передаем в конструктор тип класса
        //    XmlSerializer formatter = new XmlSerializer(typeof(Vocabulary));

        //    // получаем поток, куда будем записывать сериализованный объект
        //    using (FileStream fs = new FileStream(nameOfFileXML, FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, dict);

        //        Console.WriteLine("Объект сериализован");
        //    }

        //    // десериализация
        //    using (FileStream fs = new FileStream(nameOfFileXML, FileMode.OpenOrCreate))
        //    {
        //        Vocabulary newDict = (Vocabulary)formatter.Deserialize(fs);
        //        string str = "";
        //        foreach (Word word in newDict.Words)
        //        {

        //            str = $"{str} ID={word.Id}, russian: {word.Language01}, english:{word.Language02} \n";
        //        }
        //        Console.WriteLine(str);
        //        Console.WriteLine("Объект десериализован");
        //        Console.WriteLine($"Name of dictionary: {newDict.Title}");
        //    }

        //    Console.ReadLine();
        //}

    }
}

