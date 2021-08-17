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
            
        }        

    }
}
