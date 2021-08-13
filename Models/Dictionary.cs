using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using NDict.Services;
using NDict.ViewModels;

namespace NDict.Models
{
    public static class Dictionary
    {
        static internal string title;        
        static internal List<Word> allLearningWords = new List<Word>();
        static internal int CountOfAllWords=8;
        static internal void Loaded()
        {
           GetDictionaryFromResouce();
            
        }
        static private void GetDictionaryFromResouce()
        {
            string[] dictionaryFromFile;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames()[0];
            var steam = assembly.GetManifestResourceStream(resourceName);
            var buffer = new byte[1048576];
            steam.Read(buffer, 0, buffer.Length);
            var _textFromFile = System.Text.ASCIIEncoding.UTF8.GetString(buffer).Replace("\0", "");
            var k = _textFromFile.IndexOf("000");
            CountOfAllWords = k;
            //var strTemp = _textFromFile.Substring(k);
            //dictionaryFromFile = strTemp.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            //title = dictionaryFromFile[0];
            //SetAllLearningWord(dictionaryFromFile[1..^0]);
        }

        static private void SetAllLearningWord(string [] words)
        {

            foreach (string str in words)
            {
                var word = new Word();
                var tempString = str.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                word.Id = Convert.ToInt32(tempString[0]);
                word.Lang1 = tempString[1];
                word.Lang2 = tempString[2];
                allLearningWords.Add(word);
            }

        }

    }
}
