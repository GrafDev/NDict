using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;
using NDict.Services;

namespace NDict.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Difficult { get; set; }
        public int FlagCurrent { get; set; }
        public int TypeGame { get; set; }

        public string DBWordsForLearning = "";
        public string DBLearnedWords = "";

        internal List<Word> wordsForLearning = new List<Word>();
        internal List<Word> learnedWords = new List<Word>();

        public int countWordsForLearning = 50;

        public int countLeranedWords = 10;

        public User()
        {

        }

        public void LoadedWords()
        {
            if (DBWordsForLearning != "")
            {
                wordsForLearning = Utils.ConvertStringToArrayOfWord(DBWordsForLearning);
            }
            else
            {
                wordsForLearning = SetLearningWords(NDictionary.Words);
                DBWordsForLearning = Utils.ConvertArrayOfWordToString(wordsForLearning);
            }
        }

        public List<Word> SetLearningWords(List<Word> DBWords)
        {
            List<Word> tempWords = new List<Word>();
            try
            {
                
                List<int> idWordsForLeraning = new List<int>();
                for (int i = 0; i < countWordsForLearning; i++)
                {
                    var rnd = new Random();
                    int k = rnd.Next(0, DBWords.Count - 1);
                    for (int j = 0; j < idWordsForLeraning.Count; i++)
                    {
                        if (idWordsForLeraning.Count != 0 && k == idWordsForLeraning[j])
                        {
                            k = rnd.Next(0, DBWords.Count - 1);
                        }
                    }
                    tempWords.Add(DBWords[k]);
                }
            }
            catch
            {
                //Tests.TextError(NDictionary.Words.Count.ToString());
            }
            return tempWords;
        }


    }
}
