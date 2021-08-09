using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace NDict.Models
{
    static class DataReader
    {
        static internal string textFromFile;

        static internal void GetResouce()
        {
            var _assembly = Assembly.GetExecutingAssembly();
            var resourceName = _assembly.GetManifestResourceNames()[0];
            var steam = _assembly.GetManifestResourceStream(resourceName);
            var buffer = new byte[2048];
            steam.Read(buffer, 0, buffer.Length);
            var _text = System.Text.ASCIIEncoding.ASCII.GetString(buffer).Replace("\0", "");
            textFromFile = _text;
        }

    }
}
