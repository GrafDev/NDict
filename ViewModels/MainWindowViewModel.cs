﻿using System;
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

        private string _Title= "N-Dict copyright by Gregory Yakovlev";
        /// <summary> Title window </summary>
        public string Title{ get => _Title; set => Set(ref _Title, value); }
        #endregion
        #region Text of Button of Menu
        private string _Button_Play;
        public string Text_Button_Play { get => _Button_Play; set => Set(ref _Button_Play, value); }

        private string _Button_Close="Close";
        public string Text_Button_Close { get => _Button_Close; set => Set(ref _Button_Close, value); }

        private string _Button_Profile = Players.CurrentUser.Name;
        public string Text_Button_Profile { get => _Button_Profile; set => Set(ref _Button_Profile, value); }

        public bool FlagButtonClose=true;

        private string _Button_Profile_Dificult = Players.CurrentUser.Difficult.ToString();
        public string Text_Button_Profile_Dificult { get => _Button_Profile_Dificult; set => Set(ref _Button_Profile_Dificult, value); }

        private string border_Close_Thinkness = "0";
        public string Border_CloseButton_Thinkness { get => border_Close_Thinkness; set => Set(ref border_Close_Thinkness, value); }

        private string border_CloseButton_Brash = "Black";
        public string Border_CloseButton_Brash { get => border_CloseButton_Brash; set => Set(ref border_CloseButton_Brash, value); }

        private string isEnabled_ButtonOfQuestion = "False";
        public string IsEnabled_ButtonOfQuestion { get => isEnabled_ButtonOfQuestion; set => Set(ref isEnabled_ButtonOfQuestion, value); }

        private string isEnabled_ButtonOfAnswer = "False";
        public string IsEnabled_ButtonOfAnswer { get => isEnabled_ButtonOfAnswer; set => Set(ref isEnabled_ButtonOfAnswer, value); }



        #endregion
        #region Labels for Question
        private string _LabelFirstWordOfQuestion = "N-Dict";
        /// <summary> First word question</summary>
        public string LabelFirstWordOfQuestion { get => _LabelFirstWordOfQuestion; set => Set(ref _LabelFirstWordOfQuestion, value); }

        private string labelSecondWordOfQuestion = "";
        /// <summary> Second word question </summary>
        public string LabelSecondWordOfQuestion { get => labelSecondWordOfQuestion; set => Set(ref labelSecondWordOfQuestion, value); }
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
 



        public bool flagPlayProcess=false;
        public MainWindowViewModel()
        {
            Text_Button_Profile = Players.CurrentUser.Name;
            Text_Button_Play = Players.CurrentUser.TypeGame == 1 ? "Play" : "Train";
        }
    }
}
