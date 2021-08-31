using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NDict.Infrastructure.Commands;
using NDict.Models;
using NDict.Views.Windows;
using System.Windows;
using NDict.Services;


namespace NDict.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
        #region Title window

        private string _Title="NDict";
        /// <summary> Title window </summary>
        public string Title{ get => _Title; set => Set(ref _Title, value); }
        #endregion
        #region Text of Button of Menu

        private string _Button_Play = "Play ";
        public string Text_Button_Play { get => _Button_Play; set => Set(ref _Button_Play, value); }


        private string _Button_Profile = Player.Current.Name;
        public string Text_Button_Profile { get => _Button_Profile; set => Set(ref _Button_Profile, value); }

        private string _Button_Func = "Close";
        public string Text_Button_Func { get => _Button_Func; set => Set(ref _Button_Func, value); }
        #endregion
        #region Labels for Question
        private string _LabelFirstWordOfQuestion = "FirstQuestion";
        /// <summary> First word question</summary>
        public string labelFirstWordOfQuestion { get => _LabelFirstWordOfQuestion; set => Set(ref _LabelFirstWordOfQuestion, value); }

        private string _LabelSecondWordOfQuestion = "SecondQuestion";
        /// <summary> Second word question </summary>
        public string labelSecondWordOfQuestion { get => _LabelSecondWordOfQuestion; set => Set(ref _LabelSecondWordOfQuestion, value); }
        #endregion
        #region Text of Button of Answers
        private string _Button01 = "";
        public string Text_Button01 { get => _Button01; set => Set(ref _Button01, value); }

        private string _Button02 = "";
        public string Text_Button02 { get => _Button02; set => Set(ref _Button02, value); }

        private string _Button03 = "";
        public string Text_Button03 { get => _Button03; set => Set(ref _Button03, value); }

        private string _Button04 = "";
        public string Text_Button04 { get => _Button04; set => Set(ref _Button04, value); }

        private string _Button05 = "";
        public string Text_Button05 { get => _Button05; set => Set(ref _Button05, value); }

        private string _Button06 = "";
        public string Text_Button06 { get => _Button06; set => Set(ref _Button06, value); }
        #endregion
       
        #region StatusBar

        private int _CountOfAllWords = 0;
        public int CountOfAllWords { get => _CountOfAllWords; set => Set(ref _CountOfAllWords, value); }

        private int _ProgressBarValue = 10;
        public int ProgressBarValue { get => _ProgressBarValue; set => Set(ref _ProgressBarValue, value); }


        private int _CountOfError = 0;
        public int CountOfError { get => _CountOfError; set => Set(ref _CountOfError, value); }

        #endregion




        public MainWindowViewModel()
        {
            Text_Button01 = Knobs.Text[0];
            Text_Button02 = Knobs.Text[1];
            Text_Button03 = Knobs.Text[2];
            Text_Button04 = Knobs.Text[3];
            Text_Button05 = Knobs.Text[4];
            Text_Button06 = Knobs.Text[5];
        }



    }
}
