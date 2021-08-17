using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Services
{
    static class Utils
    {
        internal static string ConvertArrayToString(string[] names)
        {
            string str = "";
            foreach (string name in names)
            {
                str = str + name+"\n";
            }
            return str;
        }
    }
}
