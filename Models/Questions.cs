using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    static class Questions
    {
        


        static public void Loaded()
        {

            


        }
        static public void ShowQuestion(string First, string Second)
        {
            App.MainVM.LabelFirstWordOfQuestion = First;
            App.MainVM.LabelSecondWordOfQuestion = Second;
        }
        static public void ClearQuestion()
        {
            App.MainVM.LabelFirstWordOfQuestion = "";
            App.MainVM.LabelSecondWordOfQuestion = "";

        }
    }
}
