using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;

namespace NDict.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Difficult { get; set; }
        public int FlagCurrent {get; set;}
        public int TypeGame { get; set; }
        public string WordsForLearning { get; set; }
        public string LearnedWords { get; set; }
        public User() 
        {
        }
        public User(string _name)
        {
            Name = _name;
        }


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
