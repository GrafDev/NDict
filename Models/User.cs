using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //public int[] LearningWords { get; set; }
        //public int[] LearnedWords { get; set; }
        public int Difficult { get; set; }
        public User() { }

        //public User(string _name, int _difficult)
        //{
        //    Name = _name;
        //    Difficult = _difficult;
        //}
        //public User(bool flagLearnedWords,  int[] _words)
        //{
        //    if (flagLearnedWords)
        //    {
        //        LearnedWords = _words;
        //    }
        //    else
        //    {
        //        LearningWords = _words;
        //    }
        //}
    }
}
