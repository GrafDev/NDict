using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using NDict.ViewModels;
using NDict.Services;

namespace NDict.Models
{
    internal static  class Dictionary
    {
        static public string title;
        static public string[] dictionaryFromFile;
        static public int CountOfAllWords;
        static public Word[] allLearningWords;
        static public string TestOfArray;

        static internal void Loaded()
        {

           GetDictionaryFromResouce();
            
        }
        static private void GetDictionaryFromResouce()
        {

            var assembly = Assembly.GetExecutingAssembly();
            string[] NameOfResource = assembly.GetManifestResourceNames();
            var resourceName = assembly.GetManifestResourceNames()[1];
            var steam = assembly.GetManifestResourceStream(resourceName);
            var buffer = new byte[1048576];
            steam.Read(buffer, 0, buffer.Length);
            var _textFromFile = System.Text.ASCIIEncoding.UTF8.GetString(buffer).Replace("\0", "");
            var k = _textFromFile.IndexOf("0NDict0");
            var strTemp = _textFromFile.Substring(k);
            var _dictionaryFromFile = strTemp.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            title = _dictionaryFromFile[0];            
            dictionaryFromFile = _dictionaryFromFile[1..^0];
            CountOfAllWords = dictionaryFromFile.Length;
            SetArrayOfWords(dictionaryFromFile);
        }        
         static private void SetArrayOfWords(string[] _dictionary)
        {
            int i= 0;
            foreach (string str in _dictionary)
            {                
                var word = new Word();
                allLearningWords = new Word[CountOfAllWords];
                var tempString = str.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                word.Id = Convert.ToInt32(tempString[0]);
                word.Language1 = tempString[1];
                word.Language2 = tempString[2];
                allLearningWords[i]=word;
                i++;
                //TestOfArray = Utils.ConvertArrayOfWordToString(allLearningWords);
                TestOfArray = allLearningWords.Length.ToString();
            }
        }

    }
}

