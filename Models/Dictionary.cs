using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using NDict.ViewModels;

namespace NDict.Models
{
    internal static  class Dictionary
    {
        static public string title;
        static public string[] dictionaryFromFile;
        static public int CountOfAllWords=8;

        static internal void Loaded()
        {

           GetDictionaryFromResouce();
            
        }
        static private void GetDictionaryFromResouce()
        {
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames()[0];
            var steam = assembly.GetManifestResourceStream(resourceName);
            var buffer = new byte[1048576];
            steam.Read(buffer, 0, buffer.Length);
            var _textFromFile = System.Text.ASCIIEncoding.UTF8.GetString(buffer).Replace("\0", "");
            var k = _textFromFile.IndexOf("000");
            var strTemp = _textFromFile.Substring(0, _textFromFile.Length - 510);
            dictionaryFromFile = strTemp.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            title = strTemp;
            //SetAllLearningWord(dictionaryFromFile[1..^0]);
        }        

    }
}
