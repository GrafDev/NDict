using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;

namespace NDict.Services
{
    static class Utils
    {
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
                str = str + ($"ID {name.Id .ToString()}, ENG- {name.Language1}, RUS- {name.Language2}  \n");
            }
            return str;
        }
    }
}
