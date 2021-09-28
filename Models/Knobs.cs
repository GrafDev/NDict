using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    static internal class Knobs
    {
        static public int countOfKnobs=6;
 
        static private List<String> _text = new List<String>();
        static public List<String> Text { get => _text; set => _text = value; }

        static public List<Word> wordsForAnswer = new List<Word>();

        static public void Loaded()
        {
            Player.GetFlagLanguage();            
            for (int i = 0; i < countOfKnobs; i++)
            {
                var rnd = new Random();
                int k = rnd.Next(1, Player.CurrentUser.countWordsForLearning);
                wordsForAnswer.Add(Player.CurrentUser.wordsForLearning [k]);                
            }

        }
        static public void ShowKnobs()
        {
            Player.GetFlagLanguage();
            for (int i = 0; i < countOfKnobs; i++)
            {
                string tempStr = Player.FlagLanguage ? tempStr = wordsForAnswer[i].Language01 : tempStr = wordsForAnswer[i].Language02;
                App.MainVM.Buttons[i].Value = tempStr;
            }
            Questions.ShowQuestion(Player.FlagLanguage.ToString(), "");
        }
        static public void ClearKnobs()
        {
            for (int i = 0; i < countOfKnobs; i++)
            {
                var rnd = new Random();
                int k = rnd.Next(1, Player.CurrentUser.countWordsForLearning);
                App.MainVM.Buttons[i].Value = "";                
                App.MainVM.IsEnabled_ButtonOfAnswer = "false";
            }
        }

    }
}
