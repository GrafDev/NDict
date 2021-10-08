using System;
using System.Collections.Generic;
using System.Text;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Services
{
    static public class Tests
    {
        static public void ShowWindow()
        {            
            var testwindow = new TestWindow();            
            testwindow.Activate();
            testwindow.Show();
            

        }
        static public void Loaded()
        {
            //GetLearningWord();
            ShowWindow();
        }

        static public void GetLearningWord()
        {
            string tempstr = "";
            App.TestVM.TitleBlock = Players.CurrentUser.Name;
            foreach (Word word in Players.CurrentUser.wordsForLearning)
            {
                tempstr = tempstr + word.Language01 + "\n";
            }
            App.TestVM.Test2 = tempstr;
        }
        static public void GetLearningWordDB()
        {
            string tempstr = "";
            App.TestVM.TitleBlock = "testDB";
            foreach (Word word in NDictionary.Words)
            {
                tempstr = tempstr + word.Language01 + "\n";
            }
            App.TestVM.Test2 = tempstr;
        }

        static public void TextError(string str)
        {
            App.TestVM.Test2 = str;
        }

    }
}
