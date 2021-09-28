using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.MainWindowCommand

{
    class PlayApplicationCommand : Command
    {
        //TestWindow testWindow;

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            //testWindow = new TestWindow();
            //testWindow.Show();
            //testWindow.Activate();
            if (!App.MainVM.flagPlayProcess)
            {
                Timers.Start();                
                App.MainVM.flagPlayProcess = true;
                App.MainVM.FlagButtonClose = false;
                Questions.ClearQuestion();
                App.MainVM.Border_CloseButton_Brash = "red";
                App.MainVM.Border_CloseButton_Thinkness = "1";
                App.MainVM.IsEnabled_ButtonOfQuestion = "True";
            }

            //_Test();
        }        

    }
}
