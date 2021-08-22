using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    class User
    {
        int Id { get; set; }

        private string _name;
        internal string Name 
        {
            get
            {
               return (_name=="")?"Default":_name;
            }
            set 
            { 
                _name = value;
            }

        }
        internal int[] LearningWords { get; set; }
        internal int[] LearnedWords { get; set; }
        internal int Difficult { get; set; }
        public User() { }

        public User(string _name, int _difficult)
        {
            Name = _name;
            Difficult = _difficult;
        }
        public User(bool flagLearnedWords,  int[] _words)
        {
            if (flagLearnedWords)
            {
                LearnedWords = _words;
            }
            else
            {
                LearningWords = _words;
            }
        }
    }
}
