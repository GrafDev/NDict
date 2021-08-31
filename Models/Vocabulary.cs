using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using NDict.ViewModels;

namespace NDict.Models
{
    public class Vocabulary
    {

        public string title;
        public int CountOfDict;
        public List<Word> words = new List<Word>();
        //Поля данного класса должны полностью совпадать с полями этого же класса ConvertTXTXML
        // TODO: НА будущее организовать библиотеку для этого класса.

    }
}
