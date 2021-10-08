using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;

namespace NDict.Services
{
    static class Utils
    {
        static Random rnd = new Random();
        internal static List<Word> ConvertStringToArrayOfWord(string str)
        {
            var words=new List<Word>();
            var tempArrayOFString = str.Split(new string[] { "%" }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string _tempString in tempArrayOFString)
            {
                var _str = _tempString.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                var word = new Word();
                word.Id = Convert.ToInt32(_str[0]);
                word.Language01 = _str[1];
                word.Language02 = _str[2];
                words.Add(word);
            }
            return words;
        }

        internal static string ConvertArrayOfWordToString(List<Word> words)
        {
            string str = "";
            foreach (Word name in words)
            {
                str = str + ($"{name.Id.ToString()}*{name.Language01}*{name.Language02}%");
            }
            return str;
        }

        internal static void Shuffle<T>(this IList<T> _list)//перемешивание списка
        {
            int n = _list.Count;
            while (n > 1)
            {
                
                n--;
                int k = rnd.Next(n + 1);
                T value = _list[k];
                _list[k] = _list[n];
                _list[n] = value;
            }
        }
    }
}
