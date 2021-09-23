using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    static internal class Knobs
    {
        static private int countOfKnobs=6;
        static private List<String> _text = new List<String>();
        static private bool Firstlanguage;
        static public List<String> Text { get => _text; set => _text = value; }        

        static public void Loaded()
        {

            Firstlanguage = true;
            for (int i = 0; i < countOfKnobs; i++)
            {
                string tempStr;
                tempStr = Firstlanguage ? tempStr = NDictionary.Words[i].Language01 : tempStr = NDictionary.Words[i].Language02;
                Text.Add(tempStr);
            }

        }
        static public void ShowKnobs()
        {

            for (int i = 0; i < countOfKnobs; i++)
            {
                var rnd = new Random();
                int k = rnd.Next(1, Players.CurrentUser.countWordsForLearning);

                App.MainVM.Text_Button01 = Players.CurrentUser.wordsForLearning[k].Language01;
            }
        }

    }
}
