using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    class User
    {
        int Id { get; set; }
        string Name { get; set; }
        int[] LearningWords { get; set; }
        int[] LearnedWords { get; set; }
        int Difficult { get; set; }
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
