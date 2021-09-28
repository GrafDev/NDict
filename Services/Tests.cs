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
            string tempstr = "";
            App.TestVM.TitleBlock = "test";
            foreach(Word word in Player.CurrentUser.wordsForLearning)
            {
                tempstr = tempstr + word.Language01 + "\n";
                
            }
            App.TestVM.Test2 = tempstr;


        }
    }
}
