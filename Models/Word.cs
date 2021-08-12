using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Services
{
    internal class Word
    {
        int id;
        string _lang1;
        string _lang2;

        public int Id { get => id; set => id = value; }
        public string Lang1 { get => _lang1; set => _lang1 = value; }
        public string Lang2 { get => _lang2; set => _lang2 = value; }
    }
}
