using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;

namespace NDict.Services
{
    static class Utils
    {
        static Random rnd = new Random();
        internal static string ConvertArrayOfStringToString(string[] names)
        {
            string str = "";
            foreach (string name in names)
            {
                str = str + name+"\n";
            }
            return str;
        }

        internal static string ConvertArrayOfWordToString(Word[] names)
        {
            string str = "";
            foreach (Word name in names)
            {
                str = str + ($"ID {name.Id .ToString()}, ENG- {name.Language01}, RUS- {name.Language02}  \n");
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
