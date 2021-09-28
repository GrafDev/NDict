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

        public List<Word> wordsForLearning =new List<Word>();
        public List<Word> learnedWords =new List<Word>();

        public int countWordsForLearning=50;
       
        public int countLeranedWords=10;

        public User()
        {
            if (wordsForLearning.Count < countWordsForLearning)
            {
                wordsForLearning = SetLearningWords();
            }
            learnedWords  = new List<Word>(); 
        }

        public List<Word> SetLearningWords()
        {
            List<Word> tempWords = new List<Word>();
            List<int> idWordsForLeraning = new List<int>();
            for (int i = 0; i < countWordsForLearning; i++)
            {
                var rnd = new Random();
                int k = rnd.Next(0, NDictionary.countOfWords - 1);
                for (int j = 0; j < idWordsForLeraning.Count; i++)
                {
                    if (idWordsForLeraning.Count != 0 && k == idWordsForLeraning[j])
                    {
                        k = rnd.Next(0, NDictionary.countOfWords - 1);
                    }
                }
                tempWords.Add(NDictionary.Words[k]);
            }
            return tempWords;
        }


    }
}
