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
        public int FlagCurrent { get; set; }
        public int TypeGame { get; set; }
        public string dBWordsForLearning;
        public string DBWordsForLearning
        { get 
            { 
                return dBWordsForLearning; 
            } 
            set
            {
                
            } }
        public string DBLearnedWords { get; set; }


        public List<Word> wordsForLearning;
        public List<Word> LearnedWords;

        public int countWordsForLearning=50;
       
        private int countLeranedWords;       

        public User()
        {
        }

    }
}
