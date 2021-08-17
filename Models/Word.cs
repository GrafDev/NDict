using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    internal class Word
    {
        private int _id;
        private string _language1;
        private string _language2;

        public int Id { get => _id; set => _id = value; }
        public string Language1 { get => _language1; set => _language1 = value; }
        public string Language2 { get => _language2; set => _language2 = value; }
    }
}
